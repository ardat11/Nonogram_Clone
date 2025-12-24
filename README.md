# Nonogram Clone - Unity Project

This project is a functional clone of the popular logic puzzle game **Nonogram** (also known as Picross or Griddlers), developed using the Unity engine. Players use numerical clues on rows and columns to reveal a hidden grid-based image.

## ⚙ Features

* **Dynamic Grid Generation:** The `GridLayoutt` class automatically creates the puzzle area at runtime based on defined horizontal and vertical dimensions.
* **Automatic Hint Calculation:** The `FillDecider` script calculates the sequences of filled blocks for each row and column according to Nonogram logic and displays them on the UI.
* **Gameplay Mechanics:**
    * **Health System:** A 3-stage health system that penalizes incorrect moves via `HealthManager`.
    * **Bonus System:** A limited-use hint system managed by `BonusManager` to help players in difficult situations.
    * **Interaction Modes:** Managed by `TouchManager`, players can toggle between Fill, Cross, and Bonus modes.
* **Game State Management:**
    * **Level Selection:** `LevelOpener` allows for switching between different prefab-based levels.
    * **Win/Loss Logic:** `FinishManager` tracks progress and triggers the victory or game-over panels.

## 📁 Project Structure

* **Assets/1)Scripts/**: All C# classes governing game logic.
    * **Nonogram/**: Core mechanics including grid logic, health, and touch controls.
* **Assets/2)Prefabs/**: Reusable game objects such as grid blocks, UI panels, and level templates.
* **Assets/3)Graphic/**: Sprites, icons, and materials.
* **Assets/4)Scenes/**: Main menu and gameplay scenes.

## 🚀 Getting Started

1.  **Unity Version:** Compatible with Unity 2022.3+ or higher.
2.  **Installation:**
    * Clone the repository to your local machine.
    * Open the project via Unity Hub.
    * Load and play from `Assets/4)Scenes/Menu.unity`.
3.  **Dependencies:** The project utilizes `TextMesh Pro` and `Unity UI` for all interface elements.

## 🛠 Technical Highlights

* **Singleton Pattern:** Key managers (`BonusManager`, `HealthManager`, `TouchManager`, `FinishManager`) are implemented as Singletons for global access.
* **Auto-Reveal Logic:** When all correct blocks in a row or column are identified, the `RevealAll()` function automatically fills the remaining spaces.
