using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableSchedulerWinform.CustomControl
{
    public interface GenericForm<Model> where Model : class
    {
        void SetModel(Model model);
        Model GetModel();

        int InsertModel();
        bool DeleteModel();
        bool UpdateModel();

        List<Model> InsertedModels();
        bool Updated { get; }

        bool Deleted { get; }
    }
}
