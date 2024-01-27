<template>
  <section class="countdown-one">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="countdown-one__content">
            <h2 class="countdown-one__title">Register now </h2><!-- /.countdown-one__title -->
            <p class="countdown-one__tag-line">get premium online courses for free!</p>
            <!-- /.countdown-one__tag-line -->
            <p class="countdown-one__text">
              Lorem ipsum gravida nibh vel velit auctor aliquetnean sollicitudin,
              lorem
              quis bibendum auci elit consequat is simply free text available in the psutis sem nibh id eis
              sed
              odio sit amet.
            </p><!-- /.countdown-one__text -->
            <ul class="countdown-one__list list-unstyled">
              <!-- content loading via js -->
            </ul><!-- /.coundown-one__list -->
          </div><!-- /.countdown-one__content -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6">
          <div class="become-teacher__form">
            <div class="become-teacher__form-top">
              <h2 class="become-teacher__form-title">
                Get free courses
              </h2><!-- /.become-teacher__form-title -->
            </div><!-- /.become-teacher__top -->
            <form @submit.prevent="register" action="/assets/inc/sendemail.php" class="become-teacher__form-content contact-form-validated">
              <input v-model="registrationData.name" type="text" placeholder="Your Name" name="name">
              <input v-model="registrationData.email" type="text" placeholder="Email Address" name="email">

              <vue-select v-model="selectedCourse" :options="courses" class="custom-dropdown" placeholder="Choose a course..." />

              <input v-model="registrationData.phoneNumber" type="text" placeholder="Phone Number" name="phone">
              <input v-model="registrationData.message" type="text" placeholder="Comment" name="message">
              <button type="submit" class="thm-btn become-teacher__form-btn">Apply For It</button>
            </form><!-- /.become-teacher__form-content -->
            <div class="result text-center"></div><!-- /.result -->
          </div><!-- /.become-teacher__form -->
        </div><!-- /.col-lg-6 -->
      </div><!-- /.row -->
    </div><!-- /.container -->
  </section>
</template>

<script>
  import VueSelect from 'vue-select';
  import https from 'https'; // Still needed for HTTPS agent

  export default {
    name: "CountdownOne",
    components: {
      VueSelect,
    },
    data() {
      return {
        selectedCourse: null,
        courses: [],
        error: false,
        registrationData: { name: '', email: '', courseId: null, phoneNumber: '', message: '' },
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async fetch() {
      try {
        const response = await this.$axios.get('/api/Courses');
        this.courses = response.data.map(course => ({ label: course.title, value: course.id }));
      } catch (error) {
        console.error('Error fetching courses or welcome message:', error);
        this.error = true;
      }
    },
    methods: {
      async register() {
        try {
          if (!this.selectedCourse) {
            // Handle the case where no course is selected
            return;
          }
          this.registrationData.courseId = this.selectedCourse.value;

          // Send registration data without FormData
          await this.$axios.post('/api/Courses/Register', this.registrationData)
            .then(response => {
              console.log(response);
              // Show success or error toast based on response
              if (response.status === 200) {
                this.$toasted.success('Registration successful!');
                setTimeout(() => {
                  window.location = '/'; // Redirect after a delay
                }, 3000);
              } else {
                this.$toasted.error('An unexpected error occurred. Please contact support.'); // Assuming a 'message' property in error response
              }
            })
            .catch(error => {
              // Handle generic errors
              this.$toasted.error('An error occurred during registration. Please try again.');
            });
        } catch (error) {
        }
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  };
</script>





<style scoped>
  .custom-dropdown {
    box-sizing: border-box !important;
    font-family: inherit !important;
    position: relative !important;
  }

  .vs--searchable .vs__dropdown-toggle {
    cursor: text !important;
  }

  .vs__dropdown-toggle {
    -webkit-appearance: none !important;
    -moz-appearance: none !important;
    appearance: none !important;
    background: var(--vs-search-input-bg);
    border: var(--vs-border-width) var(--vs-border-style) var(--vs-border-color);
    border-radius: 3px !important;
    display: flex !important;
    padding: 0 0 4px !important;
    white-space: normal !important;
  }
</style>
