using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace ITMHelper
{
    class iTunesHelper : IDisposable
    {
        dynamic iTunesApp;

        object quitHandler;

        public iTunesHelper()
        {
            Type iTunesType = Type.GetTypeFromProgID("iTunes.Application");
            this.iTunesApp = Activator.CreateInstance(iTunesType);

            this.quitHandler = new ITEventGenericHandler(iTunesQuitEvent);
            iTunesApp.OnAboutToPromptUserToQuitEvent += this.quitHandler;

            /*foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(this.iTunesApp))
            {
                Console.WriteLine(prop.Name);
            }*/
        }

        public delegate void ITEventPlayerHandler(object track);
        public delegate void ITEventGenericHandler();

        private void iTunesQuitEvent()
        {
            iTunesApp.OnAboutToPromptUserToQuitEvent -= this.quitHandler;
            // TODO: Call handler instead of exiting app
            System.Windows.Forms.Application.Exit();
        }

        public object getCurrentTrack()
        {
            return iTunesApp.CurrentTrack;
        }

        public Boolean IsTrackInLibrary(object track)
        {
            try
            {
                return ((dynamic)track).TrackDatabaseID == 0 || true;
            }
            catch (COMException ex)
            {
                return false;
            }
        }

        public object getPlayerPosition()
        {
            try
            {
                return iTunesApp.PlayerPosition;
            }
            catch (COMException ex)
            {
                return null;
            }
        }

        public object getPlayerState()
        {
            return iTunesApp.PlayerState;
        }

        public object getVersion()
        {
            return iTunesApp.Version;
        }

        public void Dispose()
        {
            // Release the COM object
            Marshal.ReleaseComObject(this.iTunesApp);
            this.iTunesApp = null;
        }
    }
}
