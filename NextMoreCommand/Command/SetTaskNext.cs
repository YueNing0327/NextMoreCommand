﻿using SkySwordKill.Next.DialogEvent;
using SkySwordKill.Next.DialogSystem;
using SkySwordKill.NextMoreCommand.Attribute;
using SkySwordKill.NextMoreCommand.Utils;
using System;
using SkySwordKill.Next;
namespace SkySwordKill.NextMoreCommand.Command
{
    [RegisterCommand]
    [DialogEvent("SetTaskNext")]
    public class SetTaskNext : IDialogEvent
    {
        public void Execute(DialogCommand command, DialogEnvironment env, Action callback)
        {
            int taskID = command.GetInt(0, -1);
            if (TaskUtils.SetTaskNextIndex(taskID))
            {
                Main.LogInfo("触发SetTaskNext");
            }
            callback?.Invoke();
        }
    }
}