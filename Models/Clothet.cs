namespace Models
{
    public class Clothet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Type Material { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}:{Id},name:{Name}";
        }
    }
}