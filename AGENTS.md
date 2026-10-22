# MEMS coding instructions for Codex

## Scope
- Work ONLY on COMP4976 Municipal Elections Management System from `requirements/MEMS-Assignment-1.pdf`.
- The file `requirements/MEMS-Assignment-1-extracted.md` is a text accessibility aid. If text extraction conflicts with the PDF, the PDF is authoritative.
- Do NOT build the COMP4977 iOS app, SwiftUI, Web API companion project, or JWT mobile authentication.
- Focus on code, tests, configuration, and the required Azure deployment. Do not produce the separate report/Word/PDF documentation deliverable.
- Note: the rubric DOES require `docs/readme.txt` and GitHub Copilot prompt/instructions/skills markdown files in the source repository. Include those minimal in-repo deliverables. Leave unknown student names and live URLs as clearly labeled placeholders instead of inventing them.

## Implementation expectations
- Use ASP.NET Core MVC, Entity Framework Core Code First, SQLite, ASP.NET Core Identity, and Bootstrap. Prefer .NET 10 if installed.
- Implement the rubric carefully: multi-municipality model; positions/seats; candidates; Super Admin vs municipality-limited admins; separate Admin area; candidate and municipality images; search, filters, public anonymous candidate selection, and printer-friendly voting guide.
- Seed municipalities, positions, sample candidates, Identity roles, and requested demo users `super` and `pm`. The assignment gives a development/demo password. Avoid exposing hardcoded test credentials to the public site; keep production secrets out of Git and ask before using any insecure production credentials.
- Keep `appsettings.Development.json` out of source control; put its path in `.gitignore`. Use appropriate environment configuration for production; no plaintext production secrets.
- Validate client side and server side, file type/content and file size, municipality ownership of IDs and records, access permissions, and uploaded filenames. Protect modifying operations with anti-forgery controls.
- Use SQLite storage location compatible with persistence in the target Azure App Service deployment; explain deployment caveats.
- Use migrations and repeatable setup instructions and local tests; do not simply claim things work without running them.
- Before any `git push`, deployment, paid Azure resource creation, or destructive command, ask for explicit user approval.

## Workflow
1. Read assignment PDF and extracted text. Generate a concise implementation checklist linked to rubric categories.
2. Inspect environment, detect `dotnet` SDK, then create solution and project in this workspace.
3. Build vertical features in stages; run `dotnet restore`, `dotnet build`, migrations, and any tests that the environment supports. Fix encountered errors.
4. Keep a factual milestone checklist and report exact steps requiring user action. Never pretend to have tested features that were not tested.
5. Summarize what is complete, what remains, and exact commands to run locally and deploy later.
