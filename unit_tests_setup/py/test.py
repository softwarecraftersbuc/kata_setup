import unittest
from main import function

class MyTest(unittest.TestCase):
    def test(self):
        self.assertEqual(function(3), 4)