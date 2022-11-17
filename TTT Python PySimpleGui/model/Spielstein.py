from model.Farbe import Farbe

class Spielstein(object):
    def __init__(self, Farbe: Farbe = None, ID: int = -1):
        self._Farbe = Farbe
        self._id = ID

    @property
    def id(self) -> int:
        return self._id

    @property
    def Farbe(self) -> Farbe:
        return self._Farbe
