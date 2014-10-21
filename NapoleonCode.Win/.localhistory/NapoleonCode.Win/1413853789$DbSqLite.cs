
namespace NapoleonCode.Win
{
    public partial class DbSqLite : BaseForm
    {

        private readonly MsSql _bll = new MsSql();
        private readonly AppConfig _appConfig;

        public DbSqLite()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }




    }
}
