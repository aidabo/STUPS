﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/14/2012
 * Time: 5:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx
{
    using System.Management.Automation;
    
    /// <summary>
    /// Description of AddTLBuildCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.Add, "TLBuild")]
    public class AddTLBuildCommand : TLBuildCmdletBase
    {
        #region Parameters
        [Parameter(Mandatory = false,
                   Position = 0,
                   ParameterSetName = "ByName")]
        public new string Name { get; set; }
        
        [Parameter(Mandatory = false)]
        public string Description { get; set; }
        
        internal new string Id { get; set; }
        #endregion Parameters
        
        protected override void ProcessRecord()
        {
            TLHelper.checkTestPlan(InputObject);
            
            var command = new TLSrvAddBuildCommand(this);
            command.Execute();
        }
    }
}
