# Delegate Playground 

Um pequeno projeto para mostrar um pouco do uso de delegate.

Nesse projeto o player pode fazer algumas coisas: andar, pular.

Se andar até cair da pequena plataforma a DeathTrap solicita ao GameController (através de uma chamada a um metodo) que mate o player. O GameController então mata o player e faz uma chamada a um delegate para avisar - a quem interessar - que o player foi morto. Após um tempinho é feito o respawn do player e, novamente, o GameController faz uso de um delegate para avisar ao mundo do evento de spawn.
