from model.Spielstein import Spielstein as SS


class Spielsteinfeld(object):
    def __init__(self, ID: int = -1):
        self._id: int = ID
        self._istFrei: bool = True
        self._Spielstein: SS

    @property
    def ist_freies_Feld(self) -> bool:
        return self._istFrei

    @property
    def Spielstein(self) -> SS | None:
        if self.ist_freies_Feld:
            return None
        else:
            return self._Spielstein

    @property
    def id(self) -> int:
        return self._id

    def lege_Spielstein(self, Stein: SS) -> bool:
        if self.ist_freies_Feld:
            self._Spielstein = Stein
            self._istFrei = False
            return True
        else:
            return False
