using CardBrowser.BLL.Enums;

namespace CardBrowser.BLL.Models
{
    public class Ability
    {
        public Ability(AbilityTypes type, int value)
        {
            Type = type;
            Value = value;
        }

        public AbilityTypes Type { get; private set; }
        public int Value { get; private set; }
    }
}
