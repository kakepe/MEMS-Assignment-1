# MEMS repository instructions

Implement only the COMP4976 MVC assignment. Follow AGENTS.md and the official requirements PDF, especially page 10. Do not add iOS, mobile APIs, JWT authentication, or the separate report.

Use .NET 10 MVC, EF Core migrations, SQLite, Identity, and Bootstrap. Keep business entities and forms separate. Restrict all admin reads and writes through AdminScope. Verify both submitted parent IDs and the ownership of existing records. Reserve municipality CRUD for Super Admin. Never rely on hidden controls for authorization.

Validate server and client input; anti-forgery protect mutations. Never bind uploaded paths or entity navigation graphs from public input. Decode and re-encode raster uploads, cap dimensions/bytes, generate stored names, and prevent path traversal. Razor-encode biographies and names. Accept only HTTP(S) websites.

Do not commit Development settings, databases, production secrets, data-protection keys, or uploads. Do not use the demo password in Production. Run restore/build/tests for relevant changes. Report exactly what was verified. Ask the owner before GitHub pushes, deployments, paid Azure operations, or destructive commands.
