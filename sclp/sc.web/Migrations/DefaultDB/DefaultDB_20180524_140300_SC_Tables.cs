using FluentMigrator;

namespace sc.Migrations.DefaultDB {

    [Migration(20180524131100)]
    public class DefaultDB_20180524_131100_SC_Initial : ForwardOnlyMigration {

        public override void Up() => Execute.EmbeddedScript("SC_Initial.sql");
    }
}