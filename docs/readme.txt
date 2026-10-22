Municipal Elections Management System — COMP4976 Assignment 1

Team members: [STUDENT NAME 1], [STUDENT NAME 2], [STUDENT NAME 3 IF APPLICABLE]
Contributions: [ENTER EACH STUDENT'S ACTUAL CONTRIBUTIONS; do not claim AI-assisted work as unaided work.]

Application: ASP.NET Core MVC, EF Core Code First migrations, SQLite, ASP.NET Core Identity,
Bootstrap. Multi-municipality administration, position/candidate CRUD, logo/photo uploads,
public directory search/filtering, and anonymous printable personal voting guides.
The 24 seeded fictional candidates now have unique names, 108-120 word biographies,
and distinct synthetic portraits. See docs/demo-portraits.md for provenance and safe upgrade behavior.

Not completed: Live Azure deployment and GitHub publication await explicit owner approval.
Student identities/contributions and the final URLs require the team's input.
D2L upload requires the student's action. Separate report intentionally excluded by owner request.
Real printer hardware, Azure persistence/restarts, and cloud runtime behavior have not been tested.

Major challenges: Initial network sandbox restrictions required approved dependency downloads.
Windows Event Log permissions disrupted the first integration run; console logging resolved this.
The first image dependency required a Release license key; it was replaced with SkiaSharp.

Special testing instructions:
1. Install .NET 10 SDK; open PowerShell at the solution root.
2. Run ./scripts/setup.ps1 (creates ignored Development settings, restores, builds, migrates).
3. Run dotnet test MEMS.sln.
4. Run dotnet run --project src/Mems.Web --launch-profile http.
5. Browse http://localhost:5069; public browsing and guide selection require no login.
6. Development demo accounts: super and pm, assignment password P@$$w0rd for both.
   super can manage all municipalities; pm sees only Pitt Meadows positions/candidates.
7. Upload only JPEG/PNG up to 2 MB. Parent records with dependents cannot be deleted.
8. Use My voting guide > Print voting guide; browser Save as PDF is supported by print CSS.
9. See README.md for automated browser checks and deploy/README.md for Azure settings.
10. Candidate/print regression: 17 tests pass in Debug and Release; both builds have zero warnings/errors.
    Run node scripts/print-check.cjs with the app running to generate Letter/A4 PDFs.
    Full biographies expand on screen; print uses compact candidate records with portraits.
    Choose Letter/A4 and disable browser headers/footers in the print dialog.

Azure URL: [AZURE_APP_URL — NOT DEPLOYED]
GitHub repository: [GITHUB_REPOSITORY_URL — NOT PUBLISHED]

Source packaging: scripts/package.ps1 creates artifacts/MEMS-Assignment-1-source.zip,
excluding local settings, databases, uploaded files, keys, build artifacts, and dependencies.
Complete this readme's team placeholders before creating the final submission archive.
