﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace e3Validation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterUsername recording.
    /// </summary>
    [TestModule("82a1eb9a-c7a2-4204-a2e5-f6ef61658aac", ModuleType.Recording, 1)]
    public partial class EnterUsername : ITestModule
    {
        /// <summary>
        /// Holds an instance of the e3ValidationRepository repository.
        /// </summary>
        public static e3ValidationRepository repo = e3ValidationRepository.Instance;

        static EnterUsername instance = new EnterUsername();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterUsername()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterUsername Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComEnclarapharmaciaE3Mobileapp.Linear.UsernameField' at Center", repo.ComEnclarapharmaciaE3Mobileapp.Linear.UsernameFieldInfo, new RecordItemIndex(0));
            repo.ComEnclarapharmaciaE3Mobileapp.Linear.UsernameField.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'mtes8750' on item 'ComEnclarapharmaciaE3Mobileapp.Linear.UsernameField'.", repo.ComEnclarapharmaciaE3Mobileapp.Linear.UsernameFieldInfo, new RecordItemIndex(1));
            repo.ComEnclarapharmaciaE3Mobileapp.Linear.UsernameField.Element.SetAttributeValue("Text", "mtes8750");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}