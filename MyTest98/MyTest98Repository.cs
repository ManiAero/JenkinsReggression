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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest98
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest98Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("993cbe5f-ce3a-4518-bfaf-1afe768fce96")]
    public partial class MyTest98Repository : RepoGenBaseFolder
    {
        static MyTest98Repository instance = new MyTest98Repository();

        /// <summary>
        /// Gets the singleton class instance representing the MyTest98Repository element repository.
        /// </summary>
        [RepositoryFolder("993cbe5f-ce3a-4518-bfaf-1afe768fce96")]
        public static MyTest98Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest98Repository() 
            : base("MyTest98Repository", "/", null, 0, false, "993cbe5f-ce3a-4518-bfaf-1afe768fce96", ".\\RepositoryImages\\MyTest98Repository993cbe5f.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("993cbe5f-ce3a-4518-bfaf-1afe768fce96")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest98RepositoryFolders
    {
    }
#pragma warning restore 0436
}
