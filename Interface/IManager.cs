using TfL_Walking_Distance_Version3.Model;

namespace TfL_Walking_Distance_Version3.Interface
{
    internal interface IManager
    {
        public bool SetDelayTime(string sName, string dName, int t, string rs);

        public bool SetRouteUpdate(string sName, string dName, STATUS st);

        public void PrintImposible();

        public void PrintDelayed();
    }
}
