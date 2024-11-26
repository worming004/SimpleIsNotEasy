// Moi développeur junior (true story)
var arrayCountryName: Array<string> = ["Belgique", "Fance", "Allemagne"]
var arrayPopulation: Array<number> = [11350000, 67000000, 82790000]

for (let i = 0; i < arrayCountryName.length; i++) {
  // Tant que les 2 arrays conservent le bon ordre, tout va bien ... mais risqué
  console.log(arrayCountryName[i] + " a une population de " + arrayPopulation[i])
}

// Moi développeur senior
type Country = { Name: string, Population: number }
const coutry: Array<Country> = [
  { Name: "Belgique", Population: 11350000 },
  { Name: "Fance", Population: 67000000 },
  { Name: "Allemagne", Population: 82790000 }
];
// for loop sur 1 array. Pas de confusion possible.
