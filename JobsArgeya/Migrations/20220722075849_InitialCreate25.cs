using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsArgeya.Migrations
{
    public partial class InitialCreate25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "officeId",
                table: "Users",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "useSSL",
                table: "Settings",
                newName: "UseSSL");

            migrationBuilder.RenameColumn(
                name: "twitter",
                table: "Settings",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Settings",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "smtpUsername",
                table: "Settings",
                newName: "SmtpUsername");

            migrationBuilder.RenameColumn(
                name: "smtpServer",
                table: "Settings",
                newName: "SmtpServer");

            migrationBuilder.RenameColumn(
                name: "smtpPort",
                table: "Settings",
                newName: "SmtpPort");

            migrationBuilder.RenameColumn(
                name: "smtpPassword",
                table: "Settings",
                newName: "SmtpPassword");

            migrationBuilder.RenameColumn(
                name: "siteColor",
                table: "Settings",
                newName: "SiteColor");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Settings",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Settings",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "linkedin",
                table: "Settings",
                newName: "Linkedin");

            migrationBuilder.RenameColumn(
                name: "keywords",
                table: "Settings",
                newName: "Keywords");

            migrationBuilder.RenameColumn(
                name: "instagram",
                table: "Settings",
                newName: "Instagram");

            migrationBuilder.RenameColumn(
                name: "facebook",
                table: "Settings",
                newName: "Facebook");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Settings",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Settings",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "adress",
                table: "Settings",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Settings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "officeId",
                table: "Settings",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "roleName",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Offices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "officeName",
                table: "Offices",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "officeDomain",
                table: "Offices",
                newName: "CompanyDomain");

            migrationBuilder.RenameColumn(
                name: "slug",
                table: "MailSubscribers",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "MailSubscribers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MailSubscribers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "jobTitle",
                table: "Jobs",
                newName: "JobTitle");

            migrationBuilder.RenameColumn(
                name: "jobSlug",
                table: "Jobs",
                newName: "JobSlug");

            migrationBuilder.RenameColumn(
                name: "jobKeywords",
                table: "Jobs",
                newName: "JobKeywords");

            migrationBuilder.RenameColumn(
                name: "jobDescription",
                table: "Jobs",
                newName: "JobDescription");

            migrationBuilder.RenameColumn(
                name: "jobContent",
                table: "Jobs",
                newName: "JobContent");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Jobs",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Jobs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "officeId",
                table: "Jobs",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "OfficeId",
                table: "Contact",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "university",
                table: "Applies",
                newName: "University");

            migrationBuilder.RenameColumn(
                name: "resume",
                table: "Applies",
                newName: "Resume");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Applies",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "jobId",
                table: "Applies",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "isIntern",
                table: "Applies",
                newName: "IsIntern");

            migrationBuilder.RenameColumn(
                name: "internStartDate",
                table: "Applies",
                newName: "InternStartDate");

            migrationBuilder.RenameColumn(
                name: "internEndDate",
                table: "Applies",
                newName: "InternEndDate");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Applies",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Applies",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "faculty",
                table: "Applies",
                newName: "Faculty");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Applies",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cvPath",
                table: "Applies",
                newName: "CvPath");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Applies",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Applies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "officeId",
                table: "Applies",
                newName: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "roleId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Users",
                newName: "officeId");

            migrationBuilder.RenameColumn(
                name: "UseSSL",
                table: "Settings",
                newName: "useSSL");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "Settings",
                newName: "twitter");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Settings",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "SmtpUsername",
                table: "Settings",
                newName: "smtpUsername");

            migrationBuilder.RenameColumn(
                name: "SmtpServer",
                table: "Settings",
                newName: "smtpServer");

            migrationBuilder.RenameColumn(
                name: "SmtpPort",
                table: "Settings",
                newName: "smtpPort");

            migrationBuilder.RenameColumn(
                name: "SmtpPassword",
                table: "Settings",
                newName: "smtpPassword");

            migrationBuilder.RenameColumn(
                name: "SiteColor",
                table: "Settings",
                newName: "siteColor");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Settings",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Settings",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "Linkedin",
                table: "Settings",
                newName: "linkedin");

            migrationBuilder.RenameColumn(
                name: "Keywords",
                table: "Settings",
                newName: "keywords");

            migrationBuilder.RenameColumn(
                name: "Instagram",
                table: "Settings",
                newName: "instagram");

            migrationBuilder.RenameColumn(
                name: "Facebook",
                table: "Settings",
                newName: "facebook");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Settings",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Settings",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Settings",
                newName: "adress");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Settings",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Settings",
                newName: "officeId");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "roleName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Offices",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Offices",
                newName: "officeName");

            migrationBuilder.RenameColumn(
                name: "CompanyDomain",
                table: "Offices",
                newName: "officeDomain");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "MailSubscribers",
                newName: "slug");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "MailSubscribers",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MailSubscribers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "Jobs",
                newName: "jobTitle");

            migrationBuilder.RenameColumn(
                name: "JobSlug",
                table: "Jobs",
                newName: "jobSlug");

            migrationBuilder.RenameColumn(
                name: "JobKeywords",
                table: "Jobs",
                newName: "jobKeywords");

            migrationBuilder.RenameColumn(
                name: "JobDescription",
                table: "Jobs",
                newName: "jobDescription");

            migrationBuilder.RenameColumn(
                name: "JobContent",
                table: "Jobs",
                newName: "jobContent");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Jobs",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jobs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Jobs",
                newName: "officeId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Contact",
                newName: "OfficeId");

            migrationBuilder.RenameColumn(
                name: "University",
                table: "Applies",
                newName: "university");

            migrationBuilder.RenameColumn(
                name: "Resume",
                table: "Applies",
                newName: "resume");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Applies",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Applies",
                newName: "jobId");

            migrationBuilder.RenameColumn(
                name: "IsIntern",
                table: "Applies",
                newName: "isIntern");

            migrationBuilder.RenameColumn(
                name: "InternStartDate",
                table: "Applies",
                newName: "internStartDate");

            migrationBuilder.RenameColumn(
                name: "InternEndDate",
                table: "Applies",
                newName: "internEndDate");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Applies",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Applies",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Faculty",
                table: "Applies",
                newName: "faculty");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Applies",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CvPath",
                table: "Applies",
                newName: "cvPath");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Applies",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Applies",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Applies",
                newName: "officeId");
        }
    }
}
