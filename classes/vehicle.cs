namespace classes {
    public class human{
        public string name;
        public int strength = 3;

        public int intelligence = 3;

        public int dexterity = 3;
        public int health = 100;

        public human(string name){
            this.name = name;
        }
        public human(string name, int strength, int intelligence, int dexterity, int health){
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        public void  attack(human player) {
            player.health -= this.strength * 5;
        }
    }
}