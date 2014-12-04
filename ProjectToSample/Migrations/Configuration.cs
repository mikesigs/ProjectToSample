using System.Data.Entity.Migrations;

namespace ProjectToSample.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjectToSample.Context";
        }

        protected override void Seed(Context context)
        {
            context.Parents.AddOrUpdate(p => p.Id,
                new Parent
                {
                    Name = "Joe",
                    Children = new[]
                    {
                        new Child {Name = "Josh", Disowned = false}
                    }
                }, new Parent
                {
                    Name = "John",
                    Children = new[]
                    {
                        new Child {Name = "David", Disowned = false},
                        new Child {Name = "Luther", Disowned = true},
                    }
                }, new Parent
                {
                    Name = "Mary",
                    Children = new[]
                    {
                        new Child {Name = "Kate", Disowned = false},
                        new Child {Name = "Marc", Disowned = false},
                        new Child {Name = "Lucas", Disowned = true},
                    }
                });

            context.SaveChanges();

        }
    }
}
