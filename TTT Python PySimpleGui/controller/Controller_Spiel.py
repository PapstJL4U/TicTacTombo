from controller.IController import IController
from model.Spieler import Spieler
from model.Spielfeld import Spielfeld
from model.Spielregeln import Spielregeln
from model.Farbe import Farbe
from model.Spielstein import Spielstein
from view.gui import gui


class Controller_Spiel(IController):
    def __init__(self, rows: int = 3, cols: int = 3, wins: int = 3):
        self._rows = rows
        self._cols = cols
        self._wins = wins
        self._spieleranzahl = 2
        spieler1 = Spieler(Farbe.Azure, "Alice 'O' Little", 0)
        spieler2 = Spieler(Farbe.Green, "Cassandra 'X' Cain", 1)
        self._DieSpieler = [spieler1, spieler2]
        self._AnDerReihe: int = 0
        self._generiere_Stein_ID = 0
        self._Feld = Spielfeld(rows, cols, 0)
        self._Regeln = Spielregeln(self._Feld, wins)
        self._gui = gui(self)
        self._gui.setSpieler(spieler1.name, spieler2.name, spieler1.Farbe, spieler2.Farbe)
        self._gui.start_up()

    def neuesSpiel(self) -> None:
        self._Feld = Spielfeld(self._rows, self._cols, 0)
        self._Regeln = Spielregeln(self._Feld, self._wins)

    def Button_pressed(self, row: int = -1, col: int = -1) -> None:
        far: Farbe = self._DieSpieler[self._AnDerReihe].Farbe
        stein_id = self._generiere_Stein_ID
        Stein = Spielstein(far, stein_id)
        if self._Regeln.ist_gueltiger_Zug(Stein, row, col):

            if self._Regeln.istGewonnen(far):
                self._gui.update_Button(row, col, far)
                self._gewonnen(self._DieSpieler[self._AnDerReihe])
            else:
                self._generiere_Stein_ID += 1
                self._gui.update_Button(row, col, far)

            self._AnDerReihe = (self._AnDerReihe + 1) % self._spieleranzahl
            self._gui.setArrow(self._DieSpieler[self._AnDerReihe].Farbe, self._AnDerReihe)

    def _gewonnen(self, sp: Spieler) -> None:
        sp.inc_wins()
        self._gui.Game_won(sp.wins, sp.id, sp.name)
