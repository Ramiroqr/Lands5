namespace Lands5.Infrastructure
{
    using Lands5.ViewModels;

    class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator() 
        { 
            //Ligaremos la pagina login con la Mainviewmodel
            this.Main  = new MainViewModel();
        }
        #endregion
    }
}
