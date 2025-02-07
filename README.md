# Blackjack-Game

This project is a fully functional **Blackjack game** developed using **.NET** and **C#**. It simulates a realistic Blackjack experience, offering players the opportunity to engage in an interactive game where they compete against a dealer. The game follows standard Blackjack rules, where the objective is to get as close to **21 points** as possible without exceeding it. The game allows the player to choose between a variety of actions, such as hitting, standing, and playing multiple rounds.

### Key Features and Functionalities:

- **Card Dealing:**
  The game begins with both the player and the dealer being dealt two cards each. The player can view their own cards, while one of the dealer's cards is hidden to simulate the mystery of the game. Cards are drawn randomly from a deck of 52 cards, and the game supports the full deck with face cards and aces having their respective point values.

- **Hit/Stand Options:**
  Players can choose to either:
  - **Hit**: Draw an additional card to improve their hand.
  - **Stand**: Keep their current hand and let the dealer take their turn.
  
  These options are crucial to the player’s strategy, allowing them to choose when to risk taking additional cards or play it safe.

- **Dealer Logic:**
  The dealer in the game follows strict rules. The dealer will draw cards until their hand totals 17 or more points, after which they must stand. If the dealer exceeds 21 points, they bust and the player wins. This rule set ensures that the dealer's behavior is consistent with how Blackjack is played in real casinos.

- **Game Flow:**
  The game proceeds in a round-based format where the player can continue to make decisions (hit or stand) until they choose to stop or bust. After the player's turn, the dealer takes their turn based on predefined logic. The outcome of each round is determined by comparing the player's hand value with the dealer's hand, considering the bust condition and whether any player hand is closer to 21.

- **Winning and Losing:**
  A round ends when either the player or the dealer busts (exceeds 21 points), or if both have finished their turns and the winner is determined based on who has the higher hand value. In the case of a tie, the round results in a push, and no one wins.

### Technical Highlights:

- **Object-Oriented Programming (OOP):**
  This game heavily relies on **OOP principles**, demonstrating the power of classes and objects to represent different aspects of the game. There are separate classes for the deck, cards, hands, and the dealer. This modular approach not only simplifies the code but also makes it more maintainable and easy to expand in the future.

- **Randomization:**
  To ensure fairness and replayability, the game uses **randomization** to shuffle the deck of cards before each game round. This ensures that every game session is different, and there’s no predictability in the order of cards, providing a dynamic and engaging experience.

- **User Input Handling:**
  Players interact with the game through text-based input, where they can choose actions like hitting or standing by typing their choices. The input is validated to ensure that players make valid choices, enhancing the game's usability and preventing errors.

- **Game Loop and Control:**
  The game runs within a loop that controls the flow of each round, from dealing cards to handling player choices, and finally determining the winner. This loop continues until the player decides to exit the game.

- **Scalability:**
  While the current version of the game is simple, the design allows for easy expansion. Future updates could include additional features like betting, multiple players, graphical user interfaces (GUIs), or even saving game states to allow for continuing play across sessions.

### Why This Project Was Created:
This project was created as an opportunity to practice and apply **C# programming** skills while learning key game development concepts, such as game logic, input handling, randomization, and the structure of object-oriented design. It also helped improve problem-solving skills by simulating a real-world application (a card game) and managing various components that interact with each other.

### Potential Future Enhancements:
1. **Graphical User Interface (GUI):** Implement a graphical interface using a framework like Windows Forms or WPF for a more visually engaging experience.
2. **Multiplayer Functionality:** Add support for multiple players, either through local or online play.
3. **Betting Mechanism:** Introduce a betting system where the player can wager virtual money and win or lose based on the game’s outcome.
4. **Game Statistics:** Track game statistics, such as wins, losses, and tie percentages, for the player over multiple rounds.

Overall, this Blackjack game not only provides entertainment but also demonstrates the application of programming concepts in a fun and interactive way. It's a solid foundation that can be further developed into a more advanced game with enhanced features and a more user-friendly interface.



<p align="center">
  <img src="https://github.com/Sarabjot19/Blackjack-Game/blob/main/Blackjack%20Gameplay%2001.png" alt="Blackjack Gameplay 01" width="800"/>
  <img src="https://github.com/Sarabjot19/Blackjack-Game/blob/main/Blackjack%20Gameplay%2002.png" alt="Blackjack Gameplay 02" width="800"/>
  <img src="https://github.com/Sarabjot19/Blackjack-Game/blob/main/Blackjack%20Gameplay%2003.png" alt="Blackjack Gameplay 03" width="800"/>

  <img src="https://github.com/Sarabjot19/Blackjack-Game/blob/main/Code%20snippet%2001.png" alt="Blackjack Code Snippet 01" width="800"/>
  <img src="https://github.com/Sarabjot19/Blackjack-Game/blob/main/Code%20snippet%2002.png" alt="Blackjack Code Snippet 02" width="800"/>
  
  
</p>

