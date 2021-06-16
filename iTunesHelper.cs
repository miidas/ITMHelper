using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ITMHelper
{
    class iTunesHelper
    {
        object iTunesApp;

        public iTunesHelper()
        {
            Type iTunesType = Type.GetTypeFromProgID("iTunes.Application");
            this.iTunesApp = Activator.CreateInstance(iTunesType);
        }

        public object getCurrentTrack()
        {
            return ((dynamic)iTunesApp).CurrentTrack;
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
                return ((dynamic)iTunesApp).PlayerPosition;
            }
            catch (COMException ex)
            {
                return null;
            }
        }

        public object getPlayerState()
        {
            return ((dynamic)iTunesApp).PlayerState;
        }

        public object getVersion()
        {
            return ((dynamic)iTunesApp).Version;
        }
    }
}
