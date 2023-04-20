using System.Windows.Forms;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class AppStartView
    {
        public static void MakeOrConnectDb(bool shouldMakeDb)
        {
            const string creatingInfo = "Creating new DataBase might take up to a minute\n" +
                                        "Please check, that you have working MSSMS installed\n" +
                                        "LocalDB is not enough!!";

            const string connectingInfo = "Connecting to existing DataBase might take a while\n" +
                                          "Please check, that you have working MSSMS installed\n" +
                                          "LocalDB is not enough!!";

            MessageBox.Show(shouldMakeDb ? creatingInfo : connectingInfo, @"Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}