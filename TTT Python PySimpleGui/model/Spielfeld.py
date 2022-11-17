from model.Spielsteinfeld import Spielsteinfeld
from model.Spielstein import Spielstein


class Spielfeld(object):
    def __init__(self, row: int = 3, col: int = 3, ID: int = -1):
        self._row = row
        self._col = col
        self._id = ID
        self._Feld: Spielsteinfeld = [[None] * col for _ in range(row)]
        self._init_Feld()

    def _init_Feld(self) -> None:
        ID = 0
        for r in range(self.row):
            for c in range(self.col):
                self.Feld[r][c] = Spielsteinfeld(ID)
                ID += 1

    @property
    def Size(self) -> tuple[int, int]:
        return (self.row, self.col)

    @property
    def row(self) -> int:
        return self._row

    @property
    def col(self) -> int:
        return self._col

    @property
    def Feld(self) -> Spielsteinfeld:
        return self._Feld

    @property
    def FeldID(self) -> int:
        return self._id

    def get_Spielstein(self, row: int = 0, col: int = 0) -> Spielstein:
        return (self.Feld[row][col]).Spielstein

    def set_Spielstein(
        self, row: int = 0, col: int = 0, Stein: Spielstein = None
    ) -> bool:
        feld: Spielsteinfeld = self.Feld[row][col]
        return feld.lege_Spielstein(Stein)
