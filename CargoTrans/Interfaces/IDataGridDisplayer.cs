using DB.Entities;

namespace CargoTrans
{
    public abstract class IDataGridDisplayer(DataGridView dataGrid)
    {
        private readonly DataGridView _dataGrid = dataGrid;

        public async Task Display(IEnumerable<CargoEntity> data)
        {
           
        }

    }
}
