using DesignPatterns.Models;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
    /// </summary>
    public class Builder
    {
        private Club Club = new();

        public Builder WithName(string name) 
        {
            Club.Name = name;

            return this;
        }

        public Builder WithFoundedDate(DateTime date)
        {
            Club.Founded = date;

            return this;
        }

        public Builder WithOwner(string owner)
        {
            Club.Owner = owner;

            return this;
        }

        private void Reset() => Club = new();

        public Club Build() 
        {
            Club club= Club;
            Reset();
            return club;
        }        
    }
}
