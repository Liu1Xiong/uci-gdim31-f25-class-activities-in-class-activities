# in-class-activities
## Devlogs
### W1
1) The cat moved away without taking the camera with it because it's no longer a subcategory under the cat and thus will not move with the cat object. 
2) https://liu1x.itch.io/92826-in-class-build

### W2
1) Because floats are fraction numbers while ints would be whole numbers, bools would be true or false, and string is text. In this case, colors required
a decimal number.
2) Because it is not tied to the ball sprite's RGB so it wouldn't venture into decimal values.
3) It told us that the line of coded needed an 'f' before the semicolon.

### W3
#### Activity 1
1) The input would be an integer for the player's friendship level and a bool for the flag for whether they know the secret, the output would be a string with the corresponding dialogue.
2) The input would be the player's sanity level which changes the light level, since an output is not needed it would be void. 
3) The input is a true or false boolean for whether we hit the beat, the output would just be whether we hit it or didn't hit it.
#### Activity 2
1) Metaphor) Using a cat, the components would be the actual cat while the class would be the animal's DNA. The member variables would be like the cat's breed (its physical features). 
#### Activity 3
1) The balls brightness perhaps stems from the lack of a limit on how bright they can get from what we coded.

### W4
Table #10
1) We found that adding a Rigid Body to the Cat and turning Freeze Rotation checked for XYZ axis allows the ball to be hit by the cat instead of phasing. We added rigid bodies to the cat and the ball since they needed to have physics and collide, but we added an is trigger to the goal as it needs to signal that the ball has scored.
2) Me and Matteo found an error in step 1 where the OnTrigger enter method written with the .tag was not working as witten on the slides. This was because the full method type was originally written as (Collider other) so we changed it to if (other.gameObject.tag == ("Goal"))

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 