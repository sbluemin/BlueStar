using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueStarGUI.Core.OneshotDungeon
{
    enum Type
    {
        // 천인
        CreationGodman,

        // 궁사
        Archer,

        // 주술사
        Magician,
    }

    class TaskContext : BlueStarTaskContext
    {
        public Type type;
    }

    class TaskFunctions
    {
        private static void CreationGodman(TaskContext context)
        {
            context.Client.Clear(50);
            context.Client.UseQuickSlot(WMKey.VK_1, 40);
            context.Client.UseQuickSlot(WMKey.VK_2, 40);
            context.Client.UseQuickSlot(WMKey.VK_3, 40);
            context.Client.UseQuickSlot(WMKey.VK_4, 40);
            context.Client.UseQuickSlot(WMKey.VK_5, 40);
            context.Client.Enter(40);
            context.Client.Delay(1000);
        }

        private static void Archer(TaskContext context)
        {
            context.Client.Clear(50);
            context.Client.UseQuickSlot(WMKey.VK_3, 40);
            context.Client.Up(40);
            context.Client.Enter(40);
            context.Client.Delay(700);
        }

        private static void Magician(TaskContext context)
        {

        }

        public static void DoOneshotDungeon(BlueStarTaskContext task)
        {
            TaskContext context = task as TaskContext;
            BaramClient client = context.Client;

            switch(context.type)
            {
                case Type.CreationGodman:
                    CreationGodman(context);
                    break;

                case Type.Archer:
                    Archer(context);
                    break;

                case Type.Magician:
                    break;
            }
        }
    }
}
