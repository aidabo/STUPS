﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 5/31/2013
 * Time: 3:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Commands
{
    using System.Management.Automation;
    
    /// <summary>
    /// Description of NewTmxTestPlatformCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "TmxTestPlatform")]
    public class NewTmxTestPlatformCommand : NewPlatformCmdletBase
    {
        protected override void BeginProcessing()
        {
            CheckCmdletParameters();
            
            var command = new TmxNewTestPlatformCommand(this);
            command.Execute();
        }
    }
}
