namespace _Scripts.Core
{
    public interface IHealth
    {
        public int GetHealth();

        public void SetHealth(int health);

        public void Heal(int amount);
    }
}