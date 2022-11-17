from abc import ABC, abstractmethod

"""Interface for the controller class to be used by the gui"""


class IController(ABC):
    @abstractmethod
    def neuesSpiel(self) -> None:
        pass

    @abstractmethod
    def Button_pressed(self, row: int = -1, col: int = -1) -> None:
        pass
