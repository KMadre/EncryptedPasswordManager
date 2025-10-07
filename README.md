# EncryptedPasswordManager
## Purpose
A locally encrypted, offline-only password manager designed for users who value privacy and data control.
All password data is stored securely on your device — no cloud storage, no network connections.

## Key Features
- AES-encrypted storage file with a customizable encryption key
- Offline-only operation — your data never leaves your system
- Lightweight WinForms interface for quick access and usability
- XML-based data schema for easy loading and saving of stored credentials
- Unit-tested encryption methods to ensure data integrity and security
- MVP architecture separating UI logic from business logic for maintainability

## Technical Details
- Language: C#
- UI Framework: WinForms
- Data Format: XML (schema validated)
- Encryption: AES (Advanced Encryption Standard)
- Architecture: Model–View–Presenter (MVP) pattern
- Testing: Basic unit tests for encryption/decryption logic
