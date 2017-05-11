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

    public class Admin___Create_User : BaseWebAiiTest
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
        [CodedStep(@"Enter text 'qa@mediacurrent.com' in 'EditMailEmail'")]
        public void Admin__Create_User_CodedStep()
        {
            // Enter text 'qa@mediacurrent.com' in 'EditMailEmail'
            Actions.SetText(Pages.AddUserDrupal.EditMailEmail,  "qa+" + currentDateTime + "@mediacurrent.com");
            
        }
    
        [CodedStep(@"Enter text 'qaadmin' in 'EditNameText'")]
        public void Admin__Create_User_CodedStep1()
        {
            // Enter text 'qaadmin' in 'EditNameText'
            Actions.SetText(Pages.AddUserDrupal.EditNameText, "qaadmin" + currentDateTime);
            
        }
    
        [CodedStep(@"Enter text 'qa@mediacurrent.com' in 'EditMailEmail'")]
        public void Admin__Create_User_Administrator_CodedStep()
        {
            // Enter text 'qa@mediacurrent.com' in 'EditMailEmail'
            Actions.SetText(Pages.AddUserDrupal.EditMailEmail, "qa" + currentDateTime + "@mediacurrent.com");
            
        }
    
        [CodedStep(@"Enter text 'qaowner' in 'EditNameText'")]
        public void Admin__Create_User_Administrator_CodedStep1()
        {
            // Enter text 'qaowner' in 'EditNameText'
            Actions.SetText(Pages.AddUserDrupal.EditNameText, "qaowner" + currentDateTime);
            
        }
    }
}
