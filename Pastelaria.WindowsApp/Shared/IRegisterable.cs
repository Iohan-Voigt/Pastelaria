using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Shared
{
    public interface IRegisterable
    {
        void RegisterInsertNew();
        void RegisterRemove();
        void RegisterUpdate();
        UserControl ObtainTable();
        void RegistersFilter();
        void RegistersGroup();
    }
}
