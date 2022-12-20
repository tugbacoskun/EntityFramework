using BusinessLayer;
using Microsoft.Extensions.Hosting;
using Persistence.EfCore;

namespace Presentation.WinForm
{
    public partial class FrmMain : Form
    {
        private readonly ICategoryService categoryService;

        public FrmMain(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;  
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblCategoryCount.Text= categoryService.Count().ToString();
        }
    }
}