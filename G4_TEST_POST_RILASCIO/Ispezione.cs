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

namespace G4_TEST_POST_RILASCIO
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Ispezione element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("dc3ade13-6d35-4591-8806-66905dba68fa")]
    public partial class Ispezione : RepoGenBaseFolder
    {
        static Ispezione instance = new Ispezione();

        /// <summary>
        /// Gets the singleton class instance representing the Ispezione element repository.
        /// </summary>
        [RepositoryFolder("dc3ade13-6d35-4591-8806-66905dba68fa")]
        public static Ispezione Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Ispezione() 
            : base("Ispezione", "/", null, 0, false, "dc3ade13-6d35-4591-8806-66905dba68fa", ".\\RepositoryImages\\Ispezionedc3ade13.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("dc3ade13-6d35-4591-8806-66905dba68fa")]
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
    public partial class IspezioneFolders
    {
    }
#pragma warning restore 0436
}
