<template>
  <section class="testimonials-one testimonials-one__home-three">
      <div class="container" v-if="testimonials.length">
          <div class="block-title text-center">
            <h2 class="block-title__title">
              {{translations.TestemonialText}} <br />
              {{translations.TestemonialTextTwo}}
            </h2><!-- /.block-title__title -->
          </div><!-- /.block-title -->
          <div class="testimonials-one__carousel owl-carousel owl-theme">
              <div class="item" v-for="testimonial in testimonials" :key="testimonial.id">
                <div class="testimonials-one__single">
                  <div class="testimonials-one__qoute">
                    <img src="/assets/images/qoute-1-1.png" alt="">
                  </div><!-- /.testimonials-one__qoute -->
                  <p class="testimonials-one__text">{{testimonial.textEng}}</p><!-- /.testimonials-one__text -->

                  <img :src="'/assets/images/custom/' + getFirstName(testimonial.fullNameEng) + '_206.jpg'" alt="" class="testimonials-one__img">
                  <h3 class="testimonials-one__name">{{testimonial.fullNameEng}}</h3><!-- /.testimonials-one__name -->
                  <p class="testimonials-one__designation">{{testimonial.positionEng}}</p><!-- /.testimonials-one__designation -->
                </div><!-- /.testimonials-one__single -->
              </div><!-- /.item -->
          </div><!-- /.testimonials-one__carousel owl-carousel owl-theme -->
      </div><!-- /.container -->
  </section>
</template>

<script>
  import https from 'https';

    export default {
    name: "Testimonial",
    data() {
      return {
        testimonials: [],
        error: false,
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    methods: {
      getFirstName(fullName) {
        if (!fullName) return '';
        return fullName.split(' ')[0].toLowerCase();
      }
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Testimonials');
        this.testimonials = response.data;

      } catch (error) {
        console.error('Error fetching testimonials:', error);
        this.error = true;
      }
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
    }
</script>

<style scoped>

</style>
