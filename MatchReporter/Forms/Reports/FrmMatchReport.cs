using MatchReporter.Classes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Reports
{
    public partial class FrmMatchReport : Form
    {
        public Match Match;
        public Club HomeClub;
        public Club GuestClub;
        public Team HomeTeam;
        public Team GuestTeam;

        public BindingList<TeamPlayer> HomeTeamPlayers;
        public BindingList<TeamPlayer> GuestTeamPlayers;

        public BindingList<TeamOfficial> HomeTeamOfficials;
        public BindingList<TeamOfficial> GuestTeamOfficials;

        public string refereePairName;

        public FrmMatchReport(Match match, Club homeClub, Club guestClub, Team homeTeam, Team guestTeam,
            BindingList<TeamPlayer> homeTeamPlayers, BindingList<TeamPlayer> guestTeamPlayers,
            BindingList<TeamOfficial> homeTeamOfficials, BindingList<TeamOfficial> guestTeamOfficials, string refereePairName)
        {
            InitializeComponent();

            this.Match = match;
            this.HomeClub = homeClub;
            this.GuestClub = guestClub;
            this.HomeTeam = homeTeam;
            this.GuestTeam = guestTeam;
            this.refereePairName = refereePairName;
            this.HomeTeamPlayers = homeTeamPlayers;
            this.GuestTeamPlayers = guestTeamPlayers;
            this.HomeTeamOfficials = homeTeamOfficials;
            this.GuestTeamOfficials = guestTeamOfficials;
        }

        private void FrmMatchReport_Load(object sender, EventArgs e)
        {
            string leagueName;
            string hallName;
            int hallCapacity;
            string city;
            string spectators;
            string date;
            string time;
            string supervizor;
            string scorer;
            string timeKeeper;

            using(var db = new MatchReporterEntities())
            {
                leagueName = db.Match.Where(m => m.MatchId == this.Match.MatchId).FirstOrDefault().League.Name;
                hallName = db.Match.Where(m => m.MatchId == this.Match.MatchId).FirstOrDefault().Hall.Name;
                hallCapacity = db.Match.Where(m => m.MatchId == this.Match.MatchId).FirstOrDefault().Hall.Capacity;
                city = db.Hall.Where(h => h.Name == hallName).FirstOrDefault().City.Name;
                Delegate supervizorObject = db.Delegate.Where(d => d.DelegateId == this.Match.DelegateId).FirstOrDefault();
                supervizor = supervizorObject.FirstName + " " + supervizorObject.LastName;
            }

            spectators = this.Match.Spectators.ToString() + "/" + hallCapacity.ToString();
            date = this.Match.Date.ToShortDateString();

            string hours = this.Match.Time.Hours.ToString();
            string minutes = this.Match.Time.Minutes.ToString();
            if(this.Match.Time.Hours < 10)
            {
                hours = "0" + this.Match.Time.Hours.ToString();

            }
            if(this.Match.Time.Minutes < 10)
            {
                minutes = "0" + this.Match.Time.Minutes.ToString();
            }
            time = hours + ":" + minutes; 
            scorer = this.Match.Scorer;
            timeKeeper = this.Match.TimeKeeper;

            this.HomeTeamPlayerBindingSource.DataSource = this.HomeTeamPlayers;
            this.GuestTeamPlayerBindingSource.DataSource = this.GuestTeamPlayers;
            this.HomeTeamOfficialBindingSource.DataSource = this.HomeTeamOfficials;
            this.GuestTeamOfficialBindingSource.DataSource = this.GuestTeamOfficials;
            
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("MatchId", this.Match.MatchId.ToString()));
            parameters.Add(new ReportParameter("Round", this.Match.Round.ToString()));
            parameters.Add(new ReportParameter("LeagueName", leagueName));
            parameters.Add(new ReportParameter("HallName", hallName + ", " + city));

            parameters.Add(new ReportParameter("Spectators", spectators));
            parameters.Add(new ReportParameter("Date", date));
            parameters.Add(new ReportParameter("Time", time));

            parameters.Add(new ReportParameter("HomeTeamName", this.HomeClub.Name));
            parameters.Add(new ReportParameter("GuestTeamName", this.GuestClub.Name));

            parameters.Add(new ReportParameter("HomeTeamGoals", this.HomeTeam.Goals.ToString()));
            parameters.Add(new ReportParameter("GuestTeamGoals", this.GuestTeam.Goals.ToString()));

            parameters.Add(new ReportParameter("HomeTeamTTO1", this.HomeTeam.TTO1 != null ? this.HomeTeam.TTO1 : "    /"));
            parameters.Add(new ReportParameter("HomeTeamTTO2", this.HomeTeam.TTO2 != null ? this.HomeTeam.TTO2 : "    /"));
            parameters.Add(new ReportParameter("HomeTeamTTO3", this.HomeTeam.TTO3 != null ? this.HomeTeam.TTO3 : "    /"));

            parameters.Add(new ReportParameter("GuestTeamTTO1", this.GuestTeam.TTO1 != null ? this.GuestTeam.TTO1 : "    /"));
            parameters.Add(new ReportParameter("GuestTeamTTO2", this.GuestTeam.TTO2 != null ? this.GuestTeam.TTO2 : "    /"));
            parameters.Add(new ReportParameter("GuestTeamTTO3", this.GuestTeam.TTO3 != null ? this.GuestTeam.TTO3 : "    /"));

            parameters.Add(new ReportParameter("RefereePair", refereePairName));
            parameters.Add(new ReportParameter("Delegate", supervizor));
            parameters.Add(new ReportParameter("Scorer", scorer));
            parameters.Add(new ReportParameter("TimeKeeper", timeKeeper));

            parameters.Add(new ReportParameter("HomeTeam7m", this.HomeTeam.Goals7m.ToString() + "/" + this.HomeTeam.Attempts7m.ToString()));
            parameters.Add(new ReportParameter("GuestTeam7m", this.GuestTeam.Goals7m.ToString() + "/" + this.GuestTeam.Attempts7m.ToString()));

            this.matchReport.LocalReport.SetParameters(parameters);
            this.matchReport.RefreshReport();
        }
    }
}
