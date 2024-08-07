using GameLauncher.Connections;
using GameLauncher.UI.Controls;
using GameLauncher.UI.Forms;

namespace GameLauncher
{
    internal static class Program
    {
        public static Queue<(string message, NotifyControl.ImageType image)> QueuedNotifications = new();

        public static void GlobalNotify(string message, NotifyControl.ImageType type)
        {
            QueuedNotifications.Enqueue((message, type));
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (!System.Diagnostics.Debugger.IsAttached) 
            {
                Application.ThreadException += new
                    ThreadExceptionEventHandler(UIThreadException);

                // Set the unhandled exception mode to force all Windows Forms errors
                // to go through our handler.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                // Add the event handler for handling non-UI thread exceptions to the event. 
                AppDomain.CurrentDomain.UnhandledException += new
                    UnhandledExceptionEventHandler(UnhandledException);
            }

            ApplicationConfiguration.Initialize(); 

            // SplashForm splashForm = new();
            // new Thread(() => 
            // {
            //     Application.Run(splashForm);
            //     //Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            // }){IsBackground = true}.Start();
            
            if (Updater.DidUpdate(out Version? oldVersion))
            {
                // Compatibilty
                
                // Version 1.5.4 - change config location

                if (oldVersion < Version.Parse("1.5.4"))
                {
                    string oldPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                        "GameLauncher");
                    
                    if (Directory.Exists(oldPath))
                    {
                        string newPath = Config.AppDir;
                        Directory.Move(oldPath, newPath);
                    }
                }
                
                // Version 1.5.2 - remove themes from config
                if (oldVersion < Version.Parse("1.5.2"))
                {
                    // Saving again will overwrite unknown keys
                    Management.Config = Config.Load();
                    Management.Config.Save();
                }
            }

            
            Management.Online = IGDBObj.TestConnectivity();
            Management.Config = Config.Load();
            
            if (Management.Online)
            {
                if (!Management.IGDBViable)
                    Application.Run(new IGDBDetailsForm());

                if (!new IGDBObj(Management.Config.IGDBId!, Management.Config.IGDBSecret!).TestCredentials())
                    Application.Run(new IGDBDetailsForm());
                
                Management.IGDBObj = new(Management.Config.IGDBId!, Management.Config.IGDBSecret!);
                Management.RichPresence = new("1237693349612224562");
            }

            //splashForm.Invoke(splashForm.Close);
            
            Application.Run(new MainForm());
        }
        
        private static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception error = (Exception)e.ExceptionObject;
            
            MessageBox.Show(error.Message, "A critical error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void UIThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is RestorableError)
                MessageBox.Show(e.Exception.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (e.Exception is NotImplementedException)
                MessageBox.Show("This feature is not yet implemented", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                throw e.Exception;
        }
    }
}