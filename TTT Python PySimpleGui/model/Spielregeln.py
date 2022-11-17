from model.Spielfeld import Spielfeld
from model.Spielstein import Spielstein
from model.Farbe import Farbe


class Spielregeln(object):
    def __init__(self, win_len: int = 3, Feld: Spielfeld = None):
        self._win_length: int = win_len
        self._Feld: Spielfeld = Feld
        self._max_row: int = Feld.row
        self._max_col: int = Feld.col

    def ist_gueltiger_Zug(
        self, row: int = 0, col: int = 0, Stein: Spielstein = None
    ) -> bool:
        return self._Feld.set_Spielstein(row, col, Stein)

    def istGewonnen(self, Spielerfarbe: Farbe = None) -> bool:
        return (
            self._Horizontal(Spielerfarbe)
            or self._Vertikal(Spielerfarbe)
            or self._Diagonal(Spielerfarbe)
        )

    def _Vertikal(
        self, Spielerfarbe: Farbe = None
    ) -> bool:
        win: bool = False
        for c in range(self._max_col):
            in_a_col: int = 0
            for r in range(self._max_row):
                Stein: Spielstein = self._Feld.get_Spielstein(r, c)
                if Stein == None or Stein.Farbe != Spielerfarbe:
                    in_a_col = 0
                else:
                    in_a_col += 1

                if in_a_col >= self._win_length:
                    win = True
                    break
            if win:
                break
        return win

    def _Horizontal(
        self, Spielerfarbe: Farbe = None
    ) -> bool:
        win: bool = False
        for r in range(self._max_row):
            in_a_row: int = 0
            for c in range(self._max_col):
                Stein: Spielstein = self._Feld.get_Spielstein(r, c)
                if Stein == None or Stein.Farbe != Spielerfarbe:
                    in_a_row = 0
                else:
                    in_a_row += 1

                if in_a_row >= self._win_length:
                    win = True
                    break
            if win:
                break
        return win

    def _Diagonal(self, Spielerfarbe: Farbe = None):
        return self._dia_down(Spielerfarbe) or self._dia_up(Spielerfarbe)

    def _dia_down(self, Spielerfarbe: Farbe = None):
        
        win: bool = False
        max_index_row: int = self._max_row - self._win_length + 1
        max_index_col: int = self._max_col - self._win_length + 1

        for r in range(0,max_index_row):
            for c in range(0,max_index_col):
                in_a_dia: int = 0
                for dt in range(self._win_length):
                    Stein: Spielstein = self._Feld.get_Spielstein(r + dt, c + dt)
                    if Stein == None or Stein.Farbe != Spielerfarbe:
                        in_a_dia = 0
                    else:
                        in_a_dia += 1

                    if in_a_dia >= self._win_length:
                        win = True
                        r = max_index_row + 1
                        c = max_index_col + 1
                        break

        return win

    def _dia_up(self, Spielerfarbe: Farbe = None):
        win: bool = False

        min_index_row: int = self._win_length - 1 - 1
        max_index_col: int = self._max_col - self._win_length + 1

        for r in range(self._max_row - 1, min_index_row, -1):
            for c in range(0,max_index_col):
                in_a_dia: int = 0

                for dt in range(self._win_length):
                    Stein: Spielstein = self._Feld.get_Spielstein(r - dt, c + dt)
                    if Stein == None or Stein.Farbe != Spielerfarbe:
                        in_a_dia = 0
                    else:
                        in_a_dia += 1

                    if in_a_dia >= self._win_length:
                        win = True
                        r = min_index_row - 1
                        c = max_index_col + 1
                        break

        return win
