using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace Rinnai_Regression
{

    public class Admin___Generate_Content_Application : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
        long currentDateTime = DateTime.Now.Ticks;
        [CodedStep(@"Enter text 'qa+1@mediacurrent.com' in 'EditFieldDealerEmail0ValueEmail'")]
        public void Admin__Generate_Content_Application_CodedStep()
        {
            // Enter text 'qa+1@mediacurrent.com' in 'EditFieldDealerEmail0ValueEmail'
            Actions.SetText(Pages.CreateApplicationDrupal.EditFieldDealerEmail0ValueEmail, "qa+" + currentDateTime + "@mediacurrent.com");
            
        }
    }
}
