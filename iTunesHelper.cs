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
        dynamic iTunesApp;

        public iTunesHelper()
        {
            Type iTunesType = Type.GetTypeFromProgID("iTunes.Application");
            this.iTunesApp = Activator.CreateInstance(iTunesType);
        }

        public dynamic getCurrentTrack()
        {
            return iTunesApp.CurrentTrack;
        }

        public Boolean IsTrackInLibrary(dynamic track)
        {
            try
            {
                return track.TrackDatabaseID == 0 || true;
            }
            catch (COMException ex)
            {
                return false;
            }
        }

        public dynamic getPlayerPosition()
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

        public dynamic getPlayerState()
        {
            return iTunesApp.PlayerState;
        }

        public dynamic getVersion()
        {
            return iTunesApp.Version;
        }
    }
}
