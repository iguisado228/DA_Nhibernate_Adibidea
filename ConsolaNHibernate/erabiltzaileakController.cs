using Antlr.Runtime.Misc;
using ConsolaNHibernate;
using ConsolaNHibernate.Modeloak;
using Mysqlx.Sql;
using MySqlX.XDevAPI;
using NHibernate.Bytecode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;
using static NHibernate.Engine.Query.CallableParser;

namespace ConsolaNHibernate
{


    internal class erabiltzaileakController
    {



public void ErabiltzaileaSortu(Usuario erabiltzaileBerria)
{
    using (var session = NHibernateHelper.OpenSession())
    using (var transaction = session.BeginTransaction())
    {
        session.Save(erabiltzaileBerria);
        transaction.Commit();
    }
}

public void ErabiltzaileaEguneratu(Usuario eguneratutakoErabiltzailea)
{
    using (var session = NHibernateHelper.OpenSession())
    using (var transaction = session.BeginTransaction())
    {
        session.Update(eguneratutakoErabiltzailea);
        transaction.Commit();
    }
}

public void erabiltzaileaEzabatu(int idErabiltzailea)
{
    using (var session = NHibernateHelper.OpenSession())
    using (var transaction = session.BeginTransaction())
    {
        var erabiltzailea = session.Get<Erabiltzailea>(idErabiltzailea);
        if(erabiltzailea != null) {
            session.Delete(erabiltzailea);
            transaction.Commit();
    }
}

public IList<Erabiltzailea> ErabiltzaileakLortu()
    {
        using (var session = NHibernateHelper.OpenSession())
        {
            return session.Query<Erabiltzailea>().ToList();
        }
    }

public Erabiltzailea ErabiltzaileaLortu(int idErabiltzailea)
    {
        using (var session = NHibernateHelper.OpenSession())
        {
            return session.Get<Erabiltzailea>(idErabiltzailea);
        }
    }


    }

