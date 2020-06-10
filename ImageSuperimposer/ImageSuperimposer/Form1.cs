using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ImageSuperimposer
{
    public partial class Form1 : Form
    {
        public class BitmapJob //Bitmap Job Class
        {
            public Bitmap baseBitmap; //Base Image
            public Bitmap transparentBitmap; //Transparent Image
            public bool Lock = false; //Lock

            public BitmapJob(Bitmap baseBitmap, Bitmap transparentBitmap, bool Lock) //Consturctor
            {
                this.baseBitmap = baseBitmap; //assign parameters
                this.transparentBitmap = transparentBitmap; //assign parameters
                this.Lock = Lock; //assign parameters
            }
        }
        Thread[] threads; //define threads as global

        Random rand; //Random Variable

        Color brushColor; //Color

        List<BitmapJob> bitmapJobPool; //Job Pool List
        List<Bitmap> outputBitmaps; //Ouput Image List
        List<string> baseImages; //define base image list
        List<string> transparentImages; //defşne transparent list

        string[] wordLines; //Words to Print

        int numOfThreads; //Number of Threads
        int numOfImages; //Mumber of Images
        int poolSize; //Size of the Pool
        int lastIndex; //Last Index
        int opacity; //Opacity of the Transparent Image
        int selectedExtensionIndex; //Index for Extension
        int failed; //Number of Failure
        int counter; //Number counter

        string selectedExtension; //Extension
        string outPath; //Output Folder
        string fileName; //File Name

        int finishedThreads; //Number of Finished Threads

        Stopwatch stopwatch1, stopwatch2; //Stopwatch

        public Form1() //Form initialiser
        {
            InitializeComponent(); //Initialise

            rand = new Random(); //initialise Random

            bitmapJobPool = new List<BitmapJob>(); //Initialise Bitmap Job Pool
            outputBitmaps = new List<Bitmap>(); //Initialise Output

            cbb_outextension.Items.Add(".jpeg"); //Add Extension to Dropdown Menu
            cbb_outextension.Items.Add(".png"); //Add Extension to Dropdown Menu
            cbb_outextension.Items.Add(".gif"); //Add Extension to Dropdown Menu
            cbb_outextension.Items.Add(".bmp"); //Add Extension to Dropdown Menu
            cbb_outextension.Items.Add(".tiff"); //Add Extension to Dropdown Menu
            cbb_outextension.SelectedIndex = 0; //Select .jpeg for Export

            lbl_progress.Text = "Ready."; //Update Progress Text

            stopwatch1 = new Stopwatch(); //Initialise Stopwatch
            stopwatch2 = new Stopwatch(); //Initialise Stopwatch
        }

        private void btn_imageFolder_Click(object sender, EventArgs e) //chose image folder button click method
        {
            imageFolder.ShowDialog(); //show folder chose dialog
            txt_imageFolder.Text = imageFolder.SelectedPath; //print the path on the textbox
        }

        private void btn_transparentFolder_Click(object sender, EventArgs e) //chose transparent images folder button click method
        {
            transparentFolder.ShowDialog(); //show folder chose dialog
            txt_transparentFolder.Text = transparentFolder.SelectedPath; //print the path on the textbox
        }

        private void btn_outputFolder_Click(object sender, EventArgs e) //chose output images folder button click method
        {
            outputFolder.ShowDialog(); //show folder chose dialog
            txt_outputFolder.Text = outputFolder.SelectedPath; //print the path on the textbox
        }

        private void trbr_opacity_Scroll(object sender, EventArgs e) //opacity trackbar scroll method
        {
            txt_opacity.Text = trbr_opacity.Value.ToString(); //update opacity textbox
        }

        private void btn_fontSelector_Click(object sender, EventArgs e) //font selection button click method
        {
            fontSelector.ShowDialog(); //show font chose dialog
            txt_fontSelector.Text =
                fontSelector.Font.Name + " - " +
                fontSelector.Font.Size + " - " +
                fontSelector.Font.Style;
            //print font details
        }

        private void btn_openFile_Click(object sender, EventArgs e) //Open Text File Button Click Method
        {
            openFile.Filter = "Text Documents, *.txt) | *.txt"; //Filter txt Files
            openFile.ShowDialog(); //Show Chose File Dialog
            txt_openFile.Text = openFile.FileName; //Update Filename Textbox
        }

        private void btn_colorPick_Click(object sender, EventArgs e) //Select Color Button Click Method
        {
            colorPicker.ShowDialog(); //show color pick dialog
            pnl_color.BackColor = colorPicker.Color; //update color of panel
        }
        private void btn_generate_Click(object sender, EventArgs e) //image generation button click method
        {
            if (txt_imageFolder.Text == "") //validation
            {
                lbl_progress.Text = "Please Select Base Images Folder!";
                return;
            }

            if (txt_transparentFolder.Text == "") //validation
            {
                lbl_progress.Text = "Please Select Transparent Images Folder!";
                return;
            }

            if (txt_openFile.Text == "") //validation
            {
                lbl_progress.Text = "Please Select The Text File Containing Words!";
                return;
            }

            if (txt_fontSelector.Text == "") //validation
            {
                lbl_progress.Text = "Please Select a Font for The Text!";
                return;
            }

            if (txt_outputFolder.Text == "") //validation
            {
                lbl_progress.Text = "Please Select Output Folder!";
                return;
            }

            if (!int.TryParse(txt_threads.Text, out numOfThreads)) //validation
            {
                lbl_progress.Text = "Error in Threads Format!";
                txt_threads.Text = "1";
                return;
            }

            if (numOfThreads < 1) //validation
            {
                lbl_progress.Text = "Thread Number Must be Positive!";
                txt_threads.Text = "1";
            }

            if (!int.TryParse(txt_bitmapPool.Text, out poolSize)) //validation
            {
                lbl_progress.Text = "Error in pool size format!";
                txt_bitmapPool.Text = "1";
                return;
            }

            if (!int.TryParse(txt_lastIndex.Text, out lastIndex)) //validation
            {
                lbl_progress.Text = "Error in Last Index Format!";
                txt_lastIndex.Text = "1";
                return;
            }

            if (!int.TryParse(txt_opacity.Text, out opacity)) //validation
            {
                lbl_progress.Text = "Error in opacity Format!";
                txt_lastIndex.Text = "100";
                return;
            }

            brushColor = colorPicker.Color; //set color

            selectedExtensionIndex = cbb_outextension.SelectedIndex; //set index
            selectedExtension = cbb_outextension.SelectedItem.ToString(); //set extension

            outPath = txt_outputFolder.Text; //set path
            fileName = txt_filename.Text; //set name

            txt_threads.Enabled = false; //disable
            txt_bitmapPool.Enabled = false; //disable
            txt_lastIndex.Enabled = false; //disable
            trbr_opacity.Enabled = false; //disable
            txt_filename.Enabled = false; //disable
            txt_lastIndex.Enabled = false; //disable
            btn_colorPick.Enabled = false; //disable
            btn_imageFolder.Enabled = false; //disable
            btn_transparentFolder.Enabled = false; //disable
            btn_outputFolder.Enabled = false; //disable
            btn_openFile.Enabled = false; //disable
            btn_fontSelector.Enabled = false; //disable
            btn_generate.Enabled = false; //disable
            cbb_outextension.Enabled = false; //disable

            try
            {
                wordLines = System.IO.File.ReadAllLines(openFile.FileName); //read text file for lines
            }
            catch
            {

                lbl_progress.Text = "Cant Read The Text File!"; //exception

                return;
            }

            if (wordLines.Length < 1) //validation
            {
                lbl_progress.Text = "Text File is Empty!";
                return;
            }

            List<string> extensions = new List<string>() { "jpg", "jpeg", "png", "gif", "bmp", "tiff" }; //file extensions to be read

            baseImages = new List<string>(); //initalise base image list
            transparentImages = new List<string>(); //initalise transparent image list

            try
            {
                foreach (string extension in extensions) //foreach extension
                {
                    baseImages.AddRange(
                        Directory.GetFiles(
                            imageFolder.SelectedPath,
                            "*." + extension,
                            SearchOption.AllDirectories)
                        .ToList());
                    //add images with current extension to the images list

                    transparentImages.AddRange
                        (Directory.GetFiles(
                            transparentFolder.SelectedPath,
                            "*." + extension,
                            SearchOption.AllDirectories)
                        .ToList());
                    //add transparents with current extension to the transparent list
                }
            }
            catch
            {
                lbl_progress.Text = "Error While Getting File Lists!";  //validation
                return;
            }

            if (baseImages.Count < 1)  //validation
            {
                lbl_progress.Text = "Base Image Folder is Empty!";
                return;
            }

            if (transparentImages.Count < 1)  //validation
            {
                lbl_progress.Text = "Transparent Image Folder is Empty!";
                return;
            }

            stopwatch1.Reset(); //reset stopwatch
            stopwatch1.Start(); //start stopwatch
            bWorker.RunWorkerAsync(); //run background worker for generation to prevent UI unresponsiblity
            btn_generate.Visible = false; //hide generate button
            btn_stop.Visible = true; //show stop button
        }

        bool checkJobStatus() //check if there are any jobs left
        {
            foreach (BitmapJob job in bitmapJobPool) //for all jobs
            {
                if (!job.Lock) //if not locked
                {
                    return true; //there are jobs
                }
            }
            return false; //no jobs
        }

        void getJobsDone() //do jobs method
        {
            while (checkJobStatus()) //if there are jobs
            {
                BitmapJob job = getJob(); //get a job
                if (job == null) //if null exit thread
                {
                    return;
                }

                Bitmap output = new Bitmap(job.baseBitmap.Width, job.baseBitmap.Height); //initialise output

                int tcenterx = job.transparentBitmap.Width / 2; //find the center x of transparent
                int tcentery = job.transparentBitmap.Height / 2; //find the center y of thransparent

                Graphics outputgraphics = Graphics.FromImage(output); //get output graphics

                ColorMatrix matrix = new ColorMatrix(); //define new color matrix
                matrix.Matrix33 = ((float)opacity) / 100f; //set matrix opacity
                ImageAttributes attributes = new ImageAttributes(); //define new attribute to attach to bitmap
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap); //set the attribute values

                outputgraphics.CompositingMode = CompositingMode.SourceOver; //set composition mode for graphics

                outputgraphics.DrawImage(job.baseBitmap, 0, 0); //draw image on output
                outputgraphics.DrawImage(
                    job.transparentBitmap,
                    new Rectangle(
                        rand.Next(0, job.baseBitmap.Width) - tcenterx,
                        rand.Next(0, job.baseBitmap.Height) - tcentery,
                        job.transparentBitmap.Width,
                        job.transparentBitmap.Height),
                    0,
                    0,
                    job.transparentBitmap.Width,
                    job.transparentBitmap.Height,
                    GraphicsUnit.Pixel,
                    attributes); //draw transparent image on output with created attribute

                StringFormat drawFormat = new StringFormat(); //define string format
                drawFormat.Alignment = StringAlignment.Center; //define alignment
                outputgraphics.DrawString(
                    wordLines[rand.Next(0, wordLines.Length)],
                    fontSelector.Font,
                    new SolidBrush(brushColor),
                job.baseBitmap.Width / 2 - fontSelector.Font.Size / 2,
                job.baseBitmap.Height / 2 - fontSelector.Font.Size / 2,
                drawFormat);
                //draw string in the middle of the screen
                outputBitmaps.Add(output); //add output to generated bitmaps

                //drawFormat.Dispose();
                //outputgraphics.Dispose();
                //attributes.Dispose();
                if (bWorker.CancellationPending)
                {
                    return;
                }
            }
            
            finishedThreads++; //finish thread
        }

        BitmapJob getJob() //get a job method
        {
            foreach (BitmapJob job in bitmapJobPool) //for each job
            {
                if (job != null) //if job isnt null
                {
                    if (!job.Lock) //if job isnt locked
                    {
                        job.Lock = true; //lock the job
                        return job; //return the job
                    }
                }
            }
            return null; //return null if coulndt find
        }

        private void bWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) //background worker method
        {
            numOfImages = baseImages.Count; //update number of images
            threads = new Thread[numOfThreads]; //define threads
            int numOfIterations = numOfImages / poolSize; //number of iterations
            failed = 0; //reset failed number
            counter = 0; //reset counter

            for (int i = 0; i < numOfIterations + 1; i++)
            {
                BitmapJob bitJob; //job var
                Bitmap baseBit; //base bitmap var
                Bitmap transparentBit; //transparent bitmap var

                finishedThreads = 0; //reset finished threads
                stopwatch2.Reset();
                stopwatch2.Start();
                for (int j = i * poolSize; j < (i + 1) * poolSize && j < numOfImages; j++) //read "poolsize" images
                {
                    baseBit = new Bitmap(baseImages[j]); //read base image
                    transparentBit = new Bitmap(transparentImages[rand.Next(0, transparentImages.Count)]); // read transparent image

                    bitJob = new BitmapJob(baseBit, transparentBit, false); //construct job
                    bitmapJobPool.Add(bitJob); //add to job pool
                }

                for (int j = 0; j < numOfThreads; j++) //start generating in threads
                {
                    threads[j] = new Thread(new ThreadStart(getJobsDone)); //initialise threads
                    threads[j].Start(); //start threads
                }

                while (finishedThreads != numOfThreads || checkJobStatus()) //if threads no finished or jobs arent done
                {
                    if (!bWorker.CancellationPending)
                    {
                        Thread.SpinWait(1);
                    }
                    else
                    {
                        break;
                    }
                    if(stopwatch2.Elapsed.TotalSeconds > 15)
                    {
                        bitmapJobPool.Clear(); //clear job pool
                        outputBitmaps.Clear(); //clear generated bitmaps
                        GC.WaitForPendingFinalizers();
                        GC.Collect(); //clear memory
                        bWorker.CancelAsync();
                    }
                }

                for (int j = 0; j < outputBitmaps.Count; j++) //for the generated number of bitmaps
                {
                    try
                    {
                        switch (selectedExtensionIndex) //switch for export type
                        {
                            case 0://jpeg
                                {
                                    String outpath = outPath + "\\" + fileName + lastIndex + selectedExtension.ToString();

                                    outputBitmaps[j].Save(outpath, ImageFormat.Jpeg);
                                    break;
                                }
                            case 1://png
                                {
                                    String outpath = outPath + "\\" + fileName + lastIndex + selectedExtension.ToString();

                                    outputBitmaps[j].Save(outpath, ImageFormat.Png);

                                    break;
                                }
                            case 2://gif
                                {
                                    String outpath = outPath + "\\" + fileName + lastIndex + selectedExtension.ToString();

                                    outputBitmaps[j].Save(outpath, ImageFormat.Gif);

                                    break;
                                }
                            case 3://bmp
                                {
                                    String outpath = outPath + "\\" + fileName + lastIndex + selectedExtension.ToString();

                                    outputBitmaps[j].Save(outpath, ImageFormat.Bmp);

                                    break;
                                }
                            case 4://tiff
                                {
                                    String outpath = outPath + "\\" + fileName + lastIndex + selectedExtension.ToString();

                                    outputBitmaps[j].Save(outpath, ImageFormat.Tiff);

                                    break;
                                }
                            default:
                                break;
                        }
                        counter++; //increment counter
                        lastIndex++; //increment last index
                        int percent = (int)((float)(counter + failed) / (float)numOfImages * 100);
                        bWorker.ReportProgress(percent);
                    }
                    catch
                    {
                        failed++; //increment failed
                    }

                    if(bWorker.CancellationPending)
                    {
                        bitmapJobPool.Clear(); //clear job pool
                        outputBitmaps.Clear(); //clear generated bitmaps
                        GC.WaitForPendingFinalizers();
                        GC.Collect(); //clear memory
                        e.Cancel = true;
                        return;
                    }
                }
                bitmapJobPool.Clear(); //clear job pool
                outputBitmaps.Clear(); //clear generated bitmaps
                GC.WaitForPendingFinalizers();
                GC.Collect(); //clear memory
            }
        }

        private void bWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) //background worker progress change method
        {
            prbar.Value = e.ProgressPercentage; //set progress bar
            lbl_progress.Text = (counter + failed).ToString() + "/" + numOfImages.ToString() + " (" + e.ProgressPercentage + "%)"; //update progress bar text
        }

        private void bWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) //background worker on compelte method
        {
            btn_stop.Visible = false; //hide stop button
            btn_generate.Visible = true; //show generate button
            stopwatch1.Stop(); //stop watch
            if(!e.Cancelled) //if not canceled
            {
                lbl_progress.Text =
                   "Done! " +
                   (numOfImages - failed) +
                   " out of " + numOfImages +
                   " images generated in " +
                   stopwatch1.Elapsed.ToString() +
                   " seconds.";
                //print status

                txt_lastIndex.Text = (lastIndex + 1).ToString(); //update last index
            }
            else //if canceled
            {
                lbl_progress.Text = "Generating Stopped..."; //update progress bar text
                bWorker.Dispose(); //dispose worker

                foreach(Thread t in threads) //foreach thread
                {
                    t.Abort(); //terminate thread (to make sure)
                }
            }

            prbar.Value = 0; //set progress bar to 0

            txt_threads.Enabled = true; //reactivate
            txt_bitmapPool.Enabled = true; //reactivate
            txt_lastIndex.Enabled = true; //reactivate
            trbr_opacity.Enabled = true; //reactivate
            txt_filename.Enabled = true; //reactivate
            txt_lastIndex.Enabled = true; //reactivate
            btn_colorPick.Enabled = true; //reactivate
            btn_imageFolder.Enabled = true; //reactivate
            btn_transparentFolder.Enabled = true; //reactivate
            btn_outputFolder.Enabled = true; //reactivate
            btn_openFile.Enabled = true; //reactivate
            btn_fontSelector.Enabled = true; //reactivate
            btn_generate.Enabled = true; //reactivate
            cbb_outextension.Enabled = true; //reactivate
        }

        private void btn_stop_Click(object sender, EventArgs e) //stop button on click method
        {
            bWorker.CancelAsync(); //cancel background worker
        }
    }
}