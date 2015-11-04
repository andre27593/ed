package org.institutoserpis.ed;

import static org.junit.Assert.*;

import org.junit.Test;

public class ArrayTest {

	@Test
	public void Menor() {
			//fail("Not yet implemented");
			assertEquals(5,Array.menor(new int[]{5,9,6,14}));
			assertEquals(3,Array.menor(new int[]{5,9,3,14}));
			assertEquals(7,Array.menor(new int[]{9,8,12,7}));
		}

	
	@Test
	public void indexOf() {
			//fail("Not yet implemented");
			assertEquals(0,Array.indexOf(new int[]{7,21,9,13},7)); //En que posicion esta el 7
			assertEquals(1,Array.indexOf(new int[]{7,21,9,13},21));
			assertEquals(3,Array.indexOf(new int[]{7,21,9,13},21));
			assertEquals(-1,Array.indexOf(new int[]{7,21,9,13},21));
			
			
		}
	
	@Test
	public void indexOf_empty(){
		//fail("Not yet implemented");
		assertEquals(-1,Array.indexOf(new int[]{}, 33));
		
		
	}
	
	
	@Test
	public void sort(){
		int v[]=new int[]{9,8,12,7};
		Array.sort(v);
		assertArrayEquals(new int[] {7,8,9,12}, v);
	}
}
