﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Unipply.Context;

namespace Unipply.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220502120625_SeedFacultyDataTable")]
    partial class SeedFacultyDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Unipply.Models.FacultyData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Info")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FacultyData");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6aa4c0e-edc2-4bad-a22b-8516e3637546"),
                            Info = "Facultatea Energetică și Inginerie Electrică este una dintre cele mai active facultăți din cadrul Universității Tehnice a Moldovei, cu peste 9000 de ingineri pregătiți până în prezent în domenii de importanţă naţională fără de care economia ţării nu se poate dezvolta. Misiunea FEIE este de a pregăti studenții la cel mai înalt nivel și de a-i ajuta să-și dezvolte potențialul pentru a-și urma pasiunea și a inova domeniile energetic şi electrotehnic.",
                            Title = "Faculty of Energetics and Electrical Engineering"
                        },
                        new
                        {
                            Id = new Guid("78050741-da48-451d-bdc7-e05031aa724e"),
                            Info = "Facultatea de Inginerie Mecanică, Industrială şi Transporturi (FIMIT) a fost organizată odată cu fondarea Institutului Politehnic din Chişinău, la 30 aprilie 1964, initial numindu-se Facultatea de Mecanică.  La FIMIT îşi fac studiile circa 1000 de studenţi învăţământ de licenţă şi master, cu frecvenţă şi cu frecvenţă redusă. Absolvenții facultății sunt capabili să proiecteze şi să fabrice mașini şi echipamente industriale, să garanteze buna funcționare a utilajelor moderne din domeniile industriei alimentare, să asigure managementul proceselor de transport, cât şi exploatarea tehnică a vehiculelor auto.",
                            Title = "Faculty of Mechanical and Industrial Engineering and Transports"
                        },
                        new
                        {
                            Id = new Guid("f3664286-15e9-49e5-b952-c02d744e09db"),
                            Info = "Facultatea  de Calculatoare Informatică și Microelectronică dispune de întreaga bază materială necesară desfășurării proceselor didactice şi de cercetare științifică din cadrul programelor de studii, în concordanţă cu standardele care asigură desfășurarea unui proces de învăţământ de calitate. FCIM se axează pe acele activităţi care contribuie la dezvoltarea competenţelor sub formă de cunoştinţe şi abilităţi corespunzătoare, stimularea creativităţii şi inovării, inclusiv a spiritului antreprenorial, adaptarea la noile condiţii de pe piaţa muncii.",
                            Title = "Faculty of Computers, Informatics and Microelectronics"
                        },
                        new
                        {
                            Id = new Guid("13f040e8-f953-4eb4-af06-a56501e10ef0"),
                            Info = "Inginerii în electronică şi telecomunicaţii îmbogăţesc vieţile noastre prin intermediul inovaţiei şi creativităţii. Specialiştii în acest domeniu sunt la mare căutare, iar salariile oferite sunt printre cele mai competitive de pe piaţă. Facultatea noastră este locul unde studenţii obţin competenţe practice, aplică cele învăţate, implementează idei noi şi experimentează. Suntem pasionaţi de ceea ce facem şi vrem ca studenţii noştri, având cunoştinţele necesare, să aducă schimbări utile în societate.",
                            Title = "Faculty of Engineering and Management in Electronics and Telecommunications"
                        },
                        new
                        {
                            Id = new Guid("41ba4ac4-5991-4977-a134-7c7750095021"),
                            Info = "Facultatea Tehnologia Alimentelor pregăteşte specialişti pentru industria şi unităţile alimentaţiei publice, fiind cea mai mare unitate de învăţământ din domeniul alimentar din R. Moldova. În cadrul facultăţii noastre studenţii explorează domeniul alimentar cu o mare curiozitate, învaţă cu pasiune, obţin abilităţi practice și inovează domeniul.Ne bucurăm că fiecare este  pregătit pentru o carieră interesantă şi căutat în industria alimentară.Absolvenţii noştri sunt angajaţi în instituții și companii locale, naționale sau în mari întreprinderi internaționale, fiind responsabili de controlul calităţii, managementul producţiei, dezvoltarea noilor produse şi promovarea lor pe piaţa agroalimentară.",
                            Title = "Faculty of Food Technology"
                        },
                        new
                        {
                            Id = new Guid("0e2aed9e-99eb-41c4-a3ad-a06bf63459e2"),
                            Info = "Tindem să creăm la facultate un mediu de studiu centrat pe student, în care simbioza teoriei și practicii, pe platforma creativității și inovației, asigură formarea integră a viitorilor specialiști în domeniile textilelor și poligrafiei, cu abilități de design-proiectare și competențe tehnice relevante. Oportunități deosebite pentru studenții facultății noastre oferă Centrul de Excelență și Accelerare în Design și Tehnologii „ZIPhouse” al UTM. De menționat, că absolvenții Facultății Textile și Poligrafie sunt permanent solicitați pe piața muncii, peste 80% dintre aceștia fiind angajați în sectorul industriei ușoare.",
                            Title = "Faculty of Textile and Polygraphy"
                        },
                        new
                        {
                            Id = new Guid("0f64242d-fda3-4885-8a7f-4624731adfde"),
                            Info = "Facultatea Construcții, Geodezie și Cadastru (FCGC) de la Universitatea Tehnică a Moldovei este unica unitate din Republica Moldova care pregătește ingineri constructori, ingineri geodezi, ingineri în domeniul ingineriei antiincendii și protecție civilă, ingineriei și management în construcției, juriști cu cunoștințe profunde în patrimoniu, bunuri imobile. Facultatea Construcții, Geodezie și Cadastru (FCGC) de la Universitatea Tehnică a Moldovei are concurenți naționali la pregătirea inginerilor evaluatori ai bunurilor imobile, ingineri cadastrali, ceea ce ne motivează să fim mai competitivi și mai buni.",
                            Title = "Faculty of Cadastre, Geodesy and Constructions"
                        },
                        new
                        {
                            Id = new Guid("d543979a-8a39-4213-9197-84c29d4cf58a"),
                            Info = "Facultatea Urbanism şi Arhitectură  combină studiul academic cu activităţi practice, stagii de practică interesante, expoziţii, programe de mobilitate şi concursuri. În prezent FUA este principala structură universitară de stat din ţară care pregăteşte specialişti în domeniul arhitecturii şi urbanismului. Deţinem un loc de frunte în dezvoltarea artei şi culturii naţionale. Promovăm şi implementăm ideile inovative şi noile tehnologii în domeniu. Studenţii noştri se remarcă prin spirit artistic dezvoltat şi prin capacitatea de a crea lucruri inedite. Facultatea asigură cursuri de design, programe postuniversitare  (masterat, doctorat), cursuri pentru conducătorii auto şi încă multe alte facilităţi.",
                            Title = "Faculty of Architecture and Urban Planning"
                        },
                        new
                        {
                            Id = new Guid("5ec9f43e-b68c-48cc-a983-1463716f8b03"),
                            Info = "Facultatea Inginerie Economică şi Business reprezintă o comunitate ambiţioasă, cu scopuri mari, unde studenţii pot obţine competenţele necesare pentru o carieră de succes şi un viitor prosper. Suntem recunoscuţi pentru studiile de calitate şi ne mândrim cu absolvenţii noştri care beneficiază de numeroase avantaje la locul de muncă sau au iniţiat propriile afaceri. Programul nostru de studii este focusat pe aspecte teoretice şi multă practică, iar pe parcursul studiilor studenţii sunt ghidaţi şi motivaţi de cadre didactice cu experienţă.Aici îi aşteaptă noi prieteni activi, cursuri interesante, proiecte în care aplică cele învăţate, dar şi multe alte activităţi unde îşi vei dezvoltă gândirea strategică, creativitatea, ideile originale şi talentele.",
                            Title = "Faculty of Economic Engineering and Business"
                        });
                });

            modelBuilder.Entity("Unipply.Models.UserData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserData");
                });
#pragma warning restore 612, 618
        }
    }
}
