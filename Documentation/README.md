<a name='assembly'></a>
# Documentation

## Contents

- [Resources](#T-Documentation-Properties-Resources 'Documentation.Properties.Resources')
  - [Culture](#P-Documentation-Properties-Resources-Culture 'Documentation.Properties.Resources.Culture')
  - [ResourceManager](#P-Documentation-Properties-Resources-ResourceManager 'Documentation.Properties.Resources.ResourceManager')
- [Voiture](#T-Documentation-Voiture 'Documentation.Voiture')
  - [ChangementVoiture()](#M-Documentation-Voiture-ChangementVoiture-System-Decimal- 'Documentation.Voiture.ChangementVoiture(System.Decimal)')
  - [Peinture(couleurFinale)](#M-Documentation-Voiture-Peinture-System-String- 'Documentation.Voiture.Peinture(System.String)')

<a name='T-Documentation-Properties-Resources'></a>
## Resources `type`

##### Namespace

Documentation.Properties

##### Summary

Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.

<a name='P-Documentation-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Remplace la propriété CurrentUICulture du thread actuel pour toutes
  les recherches de ressources à l'aide de cette classe de ressource fortement typée.

<a name='P-Documentation-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Retourne l'instance ResourceManager mise en cache utilisée par cette classe.

<a name='T-Documentation-Voiture'></a>
## Voiture `type`

##### Namespace

Documentation

##### Summary

La classe voiture permet de modifier la couleur du véhicule choisi.
Ensuite, la classe permet de déterminer si la véhicule doit être changer ou conservé.

<a name='M-Documentation-Voiture-ChangementVoiture-System-Decimal-'></a>
### ChangementVoiture() `method`

##### Summary

La porte ChangementVoiture, est utilisée pour pouvoir déterminer si un véhicule doit être changer.
Si, le kilomètrage de la voiture est supérieur à 9999999 la méthode retourne un message important sinon le véhicule est encore bon.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Documentation-Voiture-Peinture-System-String-'></a>
### Peinture(couleurFinale) `method`

##### Summary

La méthode Peinture(), est utilisé pour changer la peinture originale de la voiture.
Puis, elle prend la peinture initiale et la change  pour  la peinture choisie.
L'évènement couleurChanged met à jour automatiquement la couleur choisie comme la nouvelle couleur de la voiture.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| couleurFinale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
