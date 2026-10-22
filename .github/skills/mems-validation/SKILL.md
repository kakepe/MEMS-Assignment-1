---
name: mems-validation
description: Verify a MEMS election-management feature against its rubric and authorization boundaries.
---

1. Map the requested behavior to the PDF rubric.
2. Trace GET and POST paths; confirm AdminScope restricts the existing record and every submitted municipality/position ID.
3. Check Super Admin and municipality admin behavior independently, including forged IDs.
4. Verify annotations, invalid forms, anti-forgery, and safe image handling where relevant.
5. Exercise the public flow without login and verify session independence.
6. Run the relevant integration tests and build. For view changes, check keyboard/mobile layout and print CSS where practical.
7. Record observed evidence and remaining untested conditions. Never invent successful deployment or screenshots.

These files guide future GitHub Copilot use. They do not assert that GitHub Copilot was used to generate the current implementation.
