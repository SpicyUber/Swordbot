using Swordbot.Survivors.Swordbot.SkillStates; 

namespace Swordbot.Survivors.Swordbot
{
    public static class SwordbotStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(UpSlash));
        }
    }
}
