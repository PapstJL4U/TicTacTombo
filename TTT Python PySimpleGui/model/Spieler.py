from model.Farbe import Farbe


class Spieler(object):
    def __init__(self, Farbe: Farbe, Name: str = "Alice Little", Id: int = -1):
        self._name = Name
        self._id = Id
        self._wins = 0
        self._Farbe = Farbe

    @property
    def name(self) -> str:
        return self._name

    @property
    def id(self) -> int:
        return self._id

    @property
    def wins(self) -> int:
        return self._wins

    def inc_wins(self) -> None:
        self._wins += 1

    @property
    def Farbe(self) -> Farbe:
        return self._Farbe

    @Farbe.setter
    def Farbe(self, Farbe: Farbe):
        self._Farbe = Farbe
