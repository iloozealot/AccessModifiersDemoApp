

using DemoLibrary;

public class ModifiedDataAccess : DataAccess
{
    public void GetUnsecureConnectionInfo()
    {
        GetConnectionString();
    }
}
