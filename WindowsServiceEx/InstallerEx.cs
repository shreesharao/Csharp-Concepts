using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;

namespace WindowsServiceEx
{
    [RunInstaller(true)]
    public partial class InstallerEx : System.Configuration.Install.Installer
    {
        public InstallerEx()
        {
            InitializeComponent();
        }
    }
}
