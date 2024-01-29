namespace TfL_Walking_Distance_Version3.Interface
{
    internal interface ICustomer
    {
        public void GetShortestPath(string start, string end);

        public bool CheckStation(string name);
    }
}
