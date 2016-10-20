using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueStarGUI.Core.ReagentCreation
{
    enum CollectType
    {
        // 시약을 바로 사용 한다.
        Use,

        // 시약을 회수 하여 보관 한다.
        Collect,
    }

    enum Type
    {
        // 1,2단계는 단계는 레벨업 용이므로 이것밖에 없다.
        HP_Low,
        HP_Middle,

        HP_High,
        MP_High,

        // 방어구 관통
        ArmorPenetration,

        // 방어도 무시
        ArmorIgnore,

        // 공격력 증가
        AttackIncreases,

        // 마력 증강
        SpellIncreases,

        // 시전 향상
        CastIncreases,
    }

    class TaskContext : BlueStarTaskContext
    {
        public CollectType collectType;
        public Type type;
    }

    class TaskFunctions
    {
        private static void SelectLevelup(TaskContext context, int level)
        {
            // 단계 선택
            for (int i = 0; i < (int)level; i++)
            {
                context.Client.Down();
            }
            context.Client.Enter();
        }

        /// <summary>
        /// 시약을 회수 한다.
        /// </summary>
        /// <param name="context"></param>
        private static void CollectReagent(TaskContext context)
        {
            // 시약 회수
            context.Client.UseItem(WMKey.VK_G);
            context.Client.Up();
            context.Client.Enter();
            context.Client.Down();
            context.Client.Down();
            context.Client.Enter();

            switch(context.collectType)
            {
                case CollectType.Use:
                    context.Client.Down();
                    break;

                case CollectType.Collect:
                    context.Client.Up();
                    break;
            }
            context.Client.Enter();
        }

        private static void Creation(TaskContext context)
        {
            // 제조
            context.Client.UseItem(WMKey.VK_G);

            // 제조(선택창)
            context.Client.Up();
            context.Client.Enter();

            // 시약제조 원격 요청 선택
            context.Client.Down();
            context.Client.Enter();

            // 시약 선택
            int level = 0;
            int downCount = 0;
            switch (context.type)
            {
                case Type.HP_Low:
                    level = 1;
                    downCount = 1;
                    break;

                case Type.HP_Middle:
                    level = 2;
                    downCount = 1;
                    break;

                case Type.HP_High:
                    level = 3;
                    downCount = 1;
                    break;

                case Type.MP_High:
                    level = 3;
                    downCount = 2;
                    break;

                case Type.AttackIncreases:
                    level = 3;
                    downCount = 6;
                    break;

                case Type.SpellIncreases:
                    level = 4;
                    downCount = 1;
                    break;

                case Type.CastIncreases:
                    level = 4;
                    downCount = 3;
                    break;

                case Type.ArmorPenetration:
                    level = 5;
                    downCount = 1;
                    break;

                case Type.ArmorIgnore:
                    level = 5;
                    downCount = 2;
                    break;
            }

            // 레벨 선택
            SelectLevelup(context, level);

            // 시약 선택
            for (int i = 0; i < downCount; i++)
            {
                context.Client.Down();
            }
            context.Client.Enter();
            context.Client.Enter();
        }

        public static void DoMakeReagentLevelUp(BlueStarTaskContext task)
        {
            TaskContext context = task as TaskContext;
            BaramClient client = context.Client;

            // 시약 회수
            client.Clear();
            CollectReagent(context);

            // 시약 제조
            client.Clear();
            Creation(context);
        }
    }
}
