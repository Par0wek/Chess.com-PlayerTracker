# Chess Tracker
Moja aplikacja z pewnością spodoba się użytkownikom strony [Chess.com](https://www.chess.com/)

Chess Tracker ma za zadanie wyświetlać i formatować statyski graczy pobierane z serwisu Chess.com. Została ona napisana z użyciem środowiska Xamarin Forms. W implementacji używano dwa rodzje plików: xaml oraz cs. Xaml to taki trochę html, więc jest odpowiedzialny za frontend aplikacji, natomiast cs zawiera kod napisany w jęzku c# i zajmuję się backendem czyli chociażby obliczaniem twojego winrate'u. Chess Tracker wykorzystuje RESTful API serwisu Chess.com ([link do api](https://www.chess.com/news/view/published-data-api)), które zawiera takie dane jak:
* Informację o graczu
* Statystyki gracza
* Archiwum gier gracza (planuję dodać do aplikacji listę ostanich gier)
* Listę utytułowanych graczy
* Informację o klubach i turniejach

### Strona Główna
Na stronie głównej znajduje się logo aplikacji wraz z miejscem do wpisania twojej nazwy użytkownika oraz lista ostanich wyszukiwań. Wpisywanie nazwy uzytkownika zawiera walidację która ma za zadanie chronić aplikację przed błędami. Sprawia ona że wprowadzona nazwa użytkownika musi istnieć w w serwisie Chess.com, a dodatkowo zostanie ona sformatowana do formatu występującego w api.

<img src="https://i.ibb.co/8MhY6NV/Screenshot-2023-04-17-08-42-07-268-com-companyname-chessapi.jpg" height="600px">

### Strona Statystyk
Po wpisaniu swojej nazwy uzytkownika zostaniesz przekierowany do strony z statystykami. Zobaczysz na niej swoją aktualną ligę, datę dołączenia oraz rating z 3 najpopularniejszych trybów. Dodatkowo wyświetlone zostaną twoje wygrane, przegrane i remisy, a do tego zostanie obliczony twój stosunek wygranych do przegranych. Na końcu statystyk znajduje się również twój najwyższy rating w zadaniach.

<img src="https://i.ibb.co/9tGff3v/Screenshot-2023-04-17-08-39-33-715-com-companyname-chessapi.jpg" height="600px">
